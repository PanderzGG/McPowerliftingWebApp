using MudCowV2.Data;
using MudCowV2.Models.Entities;

namespace MudCowV2.Services.CryptServices
{
    public class PCrypt
    {
        public PCrypt()
        {

        }

        public string pEncrypt(string password)
        {
            string pwH;

            pwH = BCrypt.Net.BCrypt.EnhancedHashPassword(password, workFactor: 13);

            return pwH;
        }

        public bool pDecrypt(string password, string passwordHash)
        { 

            bool pwH;

            pwH = BCrypt.Net.BCrypt.EnhancedVerify(password, passwordHash);

            return pwH;
        }
    }

    
}
