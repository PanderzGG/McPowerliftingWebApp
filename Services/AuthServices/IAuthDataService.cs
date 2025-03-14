using MudCowV2.Models.SignInEntities;
using System.Security.Claims;

namespace MudCowV2.Services.AuthServices
{
    public interface IAuthDataService
    {
        ServiceResponse<ClaimsPrincipal> Login(string email, string password);
    }
}
