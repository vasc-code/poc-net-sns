using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace PocAwsSnsCore.Helper
{
    public static class GlobalHelper
    {
        public static async Task<string> ToStringAsync(this Stream stream)
        {
            var reader = new StreamReader(stream);
            var rawMessage = await reader.ReadToEndAsync();
            return rawMessage;
        }

        public static async Task<T> ToAsync<T>(this Stream stream)
        {
            try
            {
                var reader = new StreamReader(stream);
                var rawMessage = await reader.ReadToEndAsync();
                var obj = System.Text.Json.JsonSerializer.Deserialize<T>(rawMessage);
                return obj;
            }
            catch (Exception)
            {
                return default;
            }
        }

        public static HttpStatusCode VerifyEndpoint(this string url)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).ConfigureAwait(false).GetAwaiter().GetResult();
                return response?.StatusCode ?? HttpStatusCode.BadRequest;
            }
        }
    }
}
