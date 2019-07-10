using System;
using System.Net.Http;
using System.Linq;
using System.Collections.Generic;
using HttpClientFactorySample.Github;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace HttpClientFactorySample.Pages
{
    public class TypedClientModel : PageModel
    {
        private readonly GitHubService _gitHubService;
        public IEnumerable<GitHubIssue> LatestIssues { get; private set; }
        public bool HasIssue => LatestIssues.Any();
        public bool GetIssuesError { get; private set; }

        public TypedClientModel(GitHubService gitHubService)
        {
            _gitHubService = gitHubService;
        }

        public async Task OnGet()
        {
            try
            {
                LatestIssues = await _gitHubService.GetAspNetDocsIssues();
            }
            catch (HttpRequestException)
            {
                GetIssuesError = true;
                LatestIssues = Array.Empty<GitHubIssue>();
            }
        }
    }
}