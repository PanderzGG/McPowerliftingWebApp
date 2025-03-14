using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;

namespace MudCowV2.Services
{
    /// <summary>
    /// Verwaltet Benutzerauthentifizierung und -autorisierung
    /// </summary>
    public class UserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly CustomAuthenticationStateProvider _authStateProvider;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public UserService(
            IHttpContextAccessor httpContextAccessor,
            CustomAuthenticationStateProvider authStateProvider,
            AuthenticationStateProvider authenticationStateProvider)
        {
            _httpContextAccessor = httpContextAccessor;
            _authStateProvider = authStateProvider;
            _authenticationStateProvider = authenticationStateProvider;
        }

        /// <summary>
        /// Holt die Benutzer-ID des aktuell angemeldeten Benutzers asynchron
        /// Versucht zuerst über AuthenticationStateProvider, dann über HttpContext
        /// </summary>
        public async Task<int?> GetCurrentUserIdAsync()
        {
            // Zuerst versuchen, über den AuthenticationStateProvider zu gehen
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var userIdClaim = authState.User.FindFirst("UserId");
            
            if (userIdClaim != null && int.TryParse(userIdClaim.Value, out var userIdFromState))
            {
                return userIdFromState;
            }
            
            // Als Fallback den HttpContext verwenden
            userIdClaim = _httpContextAccessor.HttpContext?.User.FindFirst("UserId");
            if (userIdClaim != null && int.TryParse(userIdClaim.Value, out var userId))
            {
                return userId;
            }
            
            return null;
        }

        /// <summary>
        /// Synchrone Version zum Abrufen der Benutzer-ID
        /// </summary>
        public int? GetCurrentUserId()
        {
            var userIdClaim = _httpContextAccessor.HttpContext?.User.FindFirst("UserId");
            if (userIdClaim != null && int.TryParse(userIdClaim.Value, out var userId))
            {
                return userId;
            }
            return null;
        }

        /// <summary>
        /// Synchronisiert den Authentifizierungsstatus mit den übergebenen Claims
        /// Behandelt "Headers are read-only"-Fehler durch alternative Authentifizierung
        /// </summary>
        public async Task SyncPrincipal(ClaimsPrincipal principal)
        {
            if (_httpContextAccessor.HttpContext == null)
            {
                throw new InvalidOperationException("HttpContext ist nicht verfügbar");
            }

            try
            {
                // Versuche normale Authentifizierung
                await _httpContextAccessor.HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    principal,
                    new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(120)
                    });

                // Debug-Logging für Authentifizierungsstatus
                var isAuthenticated = principal.Identity?.IsAuthenticated ?? false;
                Console.WriteLine($"SyncPrincipal - Benutzer authentifiziert: {isAuthenticated}");
                if (isAuthenticated)
                {
                    foreach (var claim in principal.Claims)
                    {
                        Console.WriteLine($"Claim in SyncPrincipal: {claim.Type} = {claim.Value}");
                    }
                }

                // Blazor über Änderung informieren
                _authStateProvider.NotifyAuthenticationStateChanged();
            }
            catch (InvalidOperationException ex) when (ex.Message.Contains("Headers are read-only"))
            {
                // Alternative Authentifizierung wenn Headers bereits gesendet wurden
                Console.WriteLine("Warnung: Headers bereits gesendet. Versuche alternative Authentifizierung.");
                _httpContextAccessor.HttpContext.User = principal;
                _authStateProvider.NotifyAuthenticationStateChanged();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler bei der Authentifizierung: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Meldet den Benutzer ab und behandelt mögliche Header-Fehler
        /// </summary>
        public async Task LogoutAsync()
        {
            if (_httpContextAccessor.HttpContext == null)
            {
                throw new InvalidOperationException("HttpContext ist nicht verfügbar");
            }

            try
            {
                // Normaler Logout-Prozess
                await _httpContextAccessor.HttpContext.SignOutAsync();
                _authStateProvider.NotifyAuthenticationStateChanged();
            }
            catch (InvalidOperationException ex) when (ex.Message.Contains("Headers are read-only"))
            {
                // Alternative Abmeldung wenn Headers bereits gesendet wurden
                Console.WriteLine("Warnung: Headers bereits gesendet. Versuche alternatives Logout.");
                _httpContextAccessor.HttpContext.User = new ClaimsPrincipal(new ClaimsIdentity());
                _authStateProvider.NotifyAuthenticationStateChanged();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Logout: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Prüft asynchron, ob ein Benutzer authentifiziert ist
        /// </summary>
        public async Task<bool> IsAuthenticatedAsync()
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            return authState.User.Identity?.IsAuthenticated ?? false;
        }

        /// <summary>
        /// Synchrone Prüfung des Authentifizierungsstatus
        /// </summary>
        public bool IsAuthenticated => _httpContextAccessor.HttpContext?.User.Identity?.IsAuthenticated ?? false;
    }
}