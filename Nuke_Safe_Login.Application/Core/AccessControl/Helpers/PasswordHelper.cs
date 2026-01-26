namespace Nuke_Safe_Login.Infra.Core.AccessControl.Helpers
{
    public static class PasswordHelper
    {
        public static string Encrypt(this string password) => BCrypt.Net.BCrypt.HashPassword(password); 
        public static bool CheckPassword(this string password, string hash) => BCrypt.Net.BCrypt.Verify(password, hash);
    }
}
