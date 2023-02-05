using System.Net;
using NUnit.Framework;
using RestSharp;

namespace Test.Project
{
    public class TrelloTest
    {
        private static RestClient _client;

        [OneTimeSetUp]
        public static void InializeRestClient() => _client = new RestClient("https://api.trello.com");

        [Test]
        public void CheckTrelloApi()
        {
            var request = new RestRequest();
            Console.WriteLine($"{_client.Options.BaseUrl} {request.Method}");

            var response = _client.Get(request);
            Console.WriteLine(response.Content);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
