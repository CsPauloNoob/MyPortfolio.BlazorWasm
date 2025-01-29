using MyPortfolio.BlazorWasm.Endpoints.Responses;
using MyPortfolio.BlazorWasm.Models;

namespace MyPortfolio.BlazorWasm.Endpoints
{
    public class GithubAPIAcess(IHttpClientFactory httpClientFactory)
    {
        private readonly HttpClient _client = 
            httpClientFactory.CreateClient(WebConfiguration.Name);

        public async Task<Response<Models.RepositorioGithub>> Get()
        {
            return null;
        }
    }
}