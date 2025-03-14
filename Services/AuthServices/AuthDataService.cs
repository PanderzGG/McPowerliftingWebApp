using Microsoft.AspNetCore.Components;
using MudCowV2.Data;
using MudCowV2.Models.SignInEntities;
using MudCowV2.Services.CryptServices;
using System.Security.Claims;


namespace MudCowV2.Services.AuthServices
{
    /// <summary>
    /// This is an example of a data service that would be used to authenticate a user.
    /// </summary>
    public class AuthDataService : IAuthDataService
    {
        private readonly AppDbContext appDbContext;
        private readonly PCrypt pCrypt;

        public AuthDataService(AppDbContext appDbContext, PCrypt pCrypt)
        {
            this.appDbContext = appDbContext;
            this.pCrypt = pCrypt;
        }

        private bool isValid;

        public ServiceResponse<ClaimsPrincipal> Login(string email, string password)
        {
            var getUser =  appDbContext.Users.Where(x => x.Email == email).ToList();

            var accountInfo = getUser[0];

            if (string.IsNullOrEmpty(email))
            {
                return new ServiceResponse<ClaimsPrincipal>("Sie müssen eine E-mail angeben");
            }

            if (string.IsNullOrEmpty(password))
            {
                return new ServiceResponse<ClaimsPrincipal>("Password is required");
            }

            if (getUser.Count == 0)
            {
                return new ServiceResponse<ClaimsPrincipal>(
                    "Ein Account mit dieser E-mail existiert nicht. Bitte registrieren Sie sich.");
            }

            isValid = pCrypt.pDecrypt(password, accountInfo.Passwordhash);

            if (!isValid)
            {
                return new ServiceResponse<ClaimsPrincipal>("Password is incorrect");
            }

            

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, accountInfo.Username),
                new Claim(ClaimTypes.Email, accountInfo.Email),
                new Claim(ClaimTypes.NameIdentifier, accountInfo.UserId.ToString()),
                new Claim(ClaimTypes.Role, accountInfo.Role)
            };

            var identity = new ClaimsIdentity(claims, "jwt");
            var principal = new ClaimsPrincipal(identity);

            return new ServiceResponse<ClaimsPrincipal>("Login successful", true, principal);
        }
    }
}
