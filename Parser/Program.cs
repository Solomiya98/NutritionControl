using System;
using System.Net.Http;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
            "https://api.github.com/repos/aspnet/AspNetCore.Docs/branches");
            //request.Headers.Add("Accept", "application/vnd.github.v3+json");
            //request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                Branches = await response.Content
                    .ReadAsAsync<IEnumerable<GitHubBranch>>();
            }
            else
            {
                GetBranchesError = true;
                Branches = Array.Empty<GitHubBranch>();
            }
        }

        static async void GetData()
        {
            //We will make a GET request to a really cool website...

            string baseUrl = "https://api.nutridigm.com/swagger/docs/v1";
            //The 'using' will help to prevent memory leaks.
            //Create a new instance of HttpClient
            using (HttpClient client = new HttpClient())

            //Setting up the response...         

            using (HttpResponseMessage res = await client.GetAsync(baseUrl))
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}
