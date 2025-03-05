namespace MCPowerlifting.Services
{
    public class LoginDecrypt
    {
        private bool passwordhash;

        public LoginDecrypt(string password, string passwordhash)
        {
            this.passwordhash = BCrypt.Net.BCrypt.EnhancedVerify(password, passwordhash);
        }
    }
}
