using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;

namespace SWAdmin
{
    class Translator
    {
        public const string url = "https://translate.googleapis.com/translate_a/single?client=gtx&sl=ja&tl=en&dt=t&q=";
        protected static HttpClient client = new HttpClient();
        protected static Dictionary<string, string> cache = new Dictionary<string, string>();

        public static string translate(string data)
        {
            data = Translator.CleanString(data);
            if (cache.ContainsKey(data))
            {
                return cache[data];
            }
            var response = client.GetAsync(url + HttpUtility.UrlEncode(data));
            string translated = Translator.FirstCharToUpper(Translator.ProcessWebResponse(response.Result));
            cache.Add(data, translated);
            File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), "cache.log"), data + " || " + translated + Environment.NewLine);
            return translated == null || string.IsNullOrEmpty(translated) ? data : translated;
        }

        private static string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: return null;
                case "": return null;
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

        private static string ProcessWebResponse(HttpResponseMessage web_response)
        {
            if (web_response.IsSuccessStatusCode)
            {
                StringBuilder sb = new StringBuilder();
                JArray json = JArray.Parse(web_response.Content.ReadAsStringAsync().Result);
                if (json.Count > 0)
                {
                    JArray jsonRes = JArray.Parse(json.First.ToString());
                    for (int i = 0; i < jsonRes.Count; i++)
                    {
                        if (jsonRes.Count > 0)
                        {
                            sb.Append(Translator.CleanString(jsonRes[i].First.ToString()));
                        }
                    }
                }
                return sb.ToString();
            }
            return null;
        }

        public static void LoadCache()
        {
            Console.WriteLine("Loading cache...");
            using (var reader = new StreamReader(new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "in_cache.log"), FileMode.Open)))
            {
                string line = String.Empty;
                string[] data;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(" || "))
                    {
                        data = line.Split(new string[] { " || " }, StringSplitOptions.None);
                        if (!Translator.cache.ContainsKey(data[0]))
                        {
                            Translator.cache.Add(data[0], data[1]);
                        }
                    }
                }
                Console.WriteLine("Cache loaded");
            }
        }

        private static string CleanString(string input)
        {
            return input.Replace("<br/>", "<br>").Replace("<br />", "<br>").Replace("\n", "<br>").Replace(" \n", "<br>").Replace("\n ", "<br>").Replace(" \n ", "<br>");
        }
    }
}
