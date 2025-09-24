using System.Text.RegularExpressions;

namespace UserManagementApp.Helpers
{
    public static class PasswordValidator
    {
        public static bool IsValid(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            if (password.Length < 8 || password.Length > 15)
                return false;

            if (!Regex.IsMatch(password, @"[A-Z]")) // Uppercase
                return false;

            if (!Regex.IsMatch(password, @"[!@#$%^&*(),.?""{}|<>_\-+=]")) // Special char
                return false;

            return true;
        }
    }
}
