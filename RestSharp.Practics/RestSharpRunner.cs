using System.Net;
using NUnit.Framework;

namespace RestSharp.Practics
{
    internal class RestSharpRunner
    {
        static void Main(string[] args)
        {
            var request = new RestRequest();
            var client = new RestClient("https://www.google.com");
            Console.WriteLine($"{client.Options.BaseUrl} {request.Method}");

            var response = client.Get(request);
            Console.WriteLine(response.Content);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}