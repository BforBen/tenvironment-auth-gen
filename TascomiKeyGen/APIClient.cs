using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace TascomiKeyGen
{
    internal sealed class APIClient
    {
        private string APIKey = "";
        private string APISecret = "";

        public DateTime Generated;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Public key</param>
        /// <param name="apiSecret">Private key</param>
        /// <param name="Uri"></param>
        /// <param name="requestMethod"></param>
        /// <param name="data"></param>
        /// <param name="debug"></param>
        public APIClient(string apiKey, string apiSecret)
        {
            APIKey = apiKey;
            APISecret = apiSecret;
        }

        public string GetToken()
        {
            string apiKeyFormatted = APIKey + GetDateDmy();

            byte[] bytes = Encoding.UTF8.GetBytes(apiKeyFormatted);
            SHA256Managed hashString = new SHA256Managed();
            byte[] hash = hashString.ComputeHash(bytes);
            string salt = hash.Aggregate(string.Empty, (current, x) => current + String.Format("{0:x2}", x));

            string tokenString;
            using (var hMAC = new HMACSHA256(Encoding.UTF8.GetBytes(APISecret)))
            {
                hMAC.ComputeHash(Encoding.UTF8.GetBytes(salt));
                tokenString = ByteToString(hMAC.Hash).ToLower();
            }

            return @"X-Public: " + APIKey + Environment.NewLine + "X-Hash: " + System.Convert.ToBase64String(Encoding.UTF8.GetBytes(tokenString));
        }

        private string ByteToString(byte[] buff)
        {
            return buff.Aggregate("", (current, t) => current + t.ToString("X2"));
        }

        private string GetDateDmy()
        {
            Generated = DateTime.Now;

            return Generated.Year + Generated.Month.ToString().PadLeft(2, '0') + Generated.Day.ToString().PadLeft(2, '0') + Generated.Hour.ToString().PadLeft(2, '0') + Generated.Minute.ToString().PadLeft(2, '0');
        }
    }
}