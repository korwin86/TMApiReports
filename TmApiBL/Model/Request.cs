using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace TmApiBL.Models
{
    public class Request
    {
        public string Title { get; }
        public string Name { get; }
        public List<string> Arguments { get; }
        public string Signature { get; }

        public Request()
        {

        }




        /// <summary>
        /// Метод делает md5 хэш строки
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string CreateMD5Hash(string input)
        {
            // Step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

    }

}
