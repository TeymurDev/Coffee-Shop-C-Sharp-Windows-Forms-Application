using System;
using System.Windows.Forms;
using System.Text;
using System.Security.Cryptography;

namespace SeeYouLatteStaff.Utilities
{
    public static class Utilities
    {
        public static void ShowMessage(string message, bool error = true)
        {
            if (error)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static string HashPassword(string password)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(password);
            byte[] hashedBytes = new SHA256Managed().ComputeHash(bytes);
            string hashedPassword = Encoding.ASCII.GetString(hashedBytes);

            return hashedPassword;
        }

        public static bool CheckPassword(string password, string hashedPassword)
        {
            return HashPassword(password) == hashedPassword;
        }
    }
}
