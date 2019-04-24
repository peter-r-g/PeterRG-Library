/*
 * 
 * Created by Peter Gorman
 * HttpRequests.cs
 * 
 */

using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PeterRG.WebRequests
{
    class HttpRequests
    {
        // The HTTP client used to make the GET and POST requests. Read only so that we don't lose any data from running transactions and we don't want multiple of these.
        public static readonly HttpClient httpClient = new HttpClient();

        /*
         * Name: Post
         * Purpose: Creates a POST request to the URL provided and supplies the given arguments in the dictionary. Upon completion the task is completed and returned.
         * Parameters: string, Dictionary<string, string>
         * Returns: string task
         */
        public static async Task<string> Post(string url, Dictionary<string, string> args)
        {
            FormUrlEncodedContent content = new FormUrlEncodedContent(args);
            var response = await httpClient.PostAsync(url, content);

            return await response.Content.ReadAsStringAsync();
        }

        /*
         * Name: Get
         * Purpose: Creates a GET request to the URL provided. Upon completion the task is completed and returned.
         * Parameters: string
         * Returns: string task
         */
        public static async Task<string> Get(string url)
        {
            return await httpClient.GetStringAsync(url);
        }
    }
}
