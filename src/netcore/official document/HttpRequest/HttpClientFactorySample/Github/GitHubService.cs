using System.Collections.Generic;
using System.Net.Http;
using System;
using System.Threading.Tasks;

namespace HttpClientFactorySample.Github
{
    public class GitHubService
    {
        public HttpClient Client { get; }

        public GitHubService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://api.github.com/");

            client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");

            client.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-Sample");

            Client = client;
        }

        public async Task<IEnumerable<GitHubIssue>> GetAspNetDocsIssues()
        {
            var response = await Client.GetAsync("/repos/aspnet/AspNetCore.Docs.issues?state=open$sort=created&direction=dec");

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsAsync<IEnumerable<GitHubIssue>>();

            return result;
        }
    }
}