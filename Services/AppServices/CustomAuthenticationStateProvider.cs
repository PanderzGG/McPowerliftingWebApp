using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace MudCowV2.Services
{
    public class CustomAuthenticationStateProvider : RevalidatingServerAuthenticationStateProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CustomAuthenticationStateProvider(
            ILoggerFactory loggerFactory,
            IHttpContextAccessor httpContextAccessor)
            : base(loggerFactory)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override TimeSpan RevalidationInterval => TimeSpan.FromMinutes(30);

        protected override Task<bool> ValidateAuthenticationStateAsync(
            AuthenticationState authenticationState,
            CancellationToken cancellationToken)
        {
            // Einfache Validierung - könnte erweitert werden
            return Task.FromResult(true);
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext == null)
            {
                // Wenn kein HttpContext verfügbar ist, gebe einen leeren Authentication State zurück
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }

            // Versuche, den Benutzer aus dem HttpContext zu bekommen
            ClaimsPrincipal user = httpContext.User;

            // Überprüfe, ob der Benutzer authentifiziert ist
            if (user.Identity == null || !user.Identity.IsAuthenticated)
            {
                // Wenn der Benutzer nicht direkt authentifiziert ist, versuche die Authentifizierung aus dem Cookie zu lesen
                var authResult = await httpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                if (authResult.Succeeded && authResult.Principal != null)
                {
                    // Wenn die Authentifizierung aus dem Cookie erfolgreich war, verwende diesen Principal
                    user = authResult.Principal;
                    
                    // Optional: Setze den authentifizierten Benutzer im HttpContext
                    httpContext.User = user;
                }
            }
            
            // Debug-Log hinzufügen, um den Authentifizierungsstatus zu überprüfen
            var isAuthenticated = user.Identity?.IsAuthenticated ?? false;
            Console.WriteLine($"User authenticated: {isAuthenticated}");
            if (isAuthenticated)
            {
                foreach (var claim in user.Claims)
                {
                    Console.WriteLine($"Claim: {claim.Type} = {claim.Value}");
                }
            }
            
            return new AuthenticationState(user);
        }

        public void NotifyAuthenticationStateChanged()
        {
            var user = _httpContextAccessor.HttpContext?.User ?? new ClaimsPrincipal(new ClaimsIdentity());
            var authState = Task.FromResult(new AuthenticationState(user));
            NotifyAuthenticationStateChanged(authState);
        }
    }
}