using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace KanyeRest
{
    public class QuoteGenerator
    {
        private HttpClient client;

        public QuoteGenerator(HttpClient client)
        {
            this.client = client;
        }

        public string Kayne()
        {
            var kanyeURL = "https://api.kanye.rest/";

            var kanyeReply = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeReply).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public string RonSwanson()
        {
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronReply = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronReply);

            return ronQuote[0].ToString();

        }
    }
}