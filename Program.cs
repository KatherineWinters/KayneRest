using System;
using System.Net.Http;

namespace KanyeRest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Kayne: {quote.Kayne()}");
                Console.WriteLine();
                Console.WriteLine($"Ron: {quote.RonSwanson()}");
                Console.WriteLine();
            }
        }
    }
}
