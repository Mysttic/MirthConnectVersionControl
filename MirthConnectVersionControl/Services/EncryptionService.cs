using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using MirthConnectVersionControl.Services.Interfaces;

namespace MirthConnectVersionControl.Services
{
    public class EncryptionService : IEncryptionService
    {
        public string Encrypt(string plainText)
        {
            if (string.IsNullOrEmpty(plainText)) return plainText;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                try
                {
                    byte[] data = Encoding.UTF8.GetBytes(plainText);
                    byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
                    return Convert.ToBase64String(encrypted);
                }
                catch (Exception)
                {
                    // Fallback or log if needed
                    return plainText;
                }
            }
            return plainText;
        }

        public string Decrypt(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText)) return cipherText;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                try
                {
                    byte[] data = Convert.FromBase64String(cipherText);
                    byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
                    return Encoding.UTF8.GetString(decrypted);
                }
                catch (Exception)
                {
                    // If decryption fails (e.g. valid string was not encrypted, or different machine), return original
                    return cipherText;
                }
            }
            return cipherText;
        }
    }
}
