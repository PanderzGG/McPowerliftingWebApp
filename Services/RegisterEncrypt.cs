namespace MCPowerlifting.Services
{
    public class RegisterEncrypt
    {
        private string? passwordhash;

        public RegisterEncrypt(string password)
        {
            this.passwordhash = BCrypt.Net.BCrypt.EnhancedHashPassword(password);
        }
    }
}
