using System.Security.Cryptography;
using System.Text;

namespace Sifreleme
{
    class SHASifreleme
    {

        public static string SHA_256_Encrypting(string deger)
        {
            SHA256 sha = SHA256.Create();
            byte[] degerBytes = Encoding.UTF8.GetBytes(deger);
            byte[] shaBytes = sha.ComputeHash(degerBytes);
            return HashToByte(shaBytes);
        }

        public static string SHA_512_Encrypting(string deger)
        {
            SHA512 sha = SHA512.Create();
            byte[] degerBytes = Encoding.UTF8.GetBytes(deger);
            byte[] sha256byte = sha.ComputeHash(degerBytes);
            return HashToByte(sha256byte);
        }

        public static string HashToByte(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            foreach (byte item in hash)
            {
                result.Append(item.ToString("x2"));

            }

            return result.ToString();
        }

    }
}