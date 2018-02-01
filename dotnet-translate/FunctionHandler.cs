using System;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace Function
{
    public class FunctionHandler
    {
        const string accessKey = "***";
        const string uriBase = "https://api.microsofttranslator.com/V1/Http.svc/Translate";
        public void Handle(string input) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (accessKey.Length == 32)
            {
            var result = AzureTranslate(input, "cy");
            Console.WriteLine(result);
            }
            else{
                Console.WriteLine("Invalid API subscription key!");
            }
        }

        /// <summary>
        /// Performs an Azure Cognitive API translation call and returns the results.
        /// </summary>
        static string AzureTranslate(string textToTranslate, string toLanguageCode)
        {
            var uriQuery = uriBase + $"?text={Uri.EscapeDataString(textToTranslate)}&to={toLanguageCode}";
            WebRequest request = HttpWebRequest.Create(uriQuery);
            request.Headers["Ocp-Apim-Subscription-Key"] = accessKey;
            HttpWebResponse response = (HttpWebResponse)request.GetResponseAsync().Result;
            string result = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return result;
        }
    }
}