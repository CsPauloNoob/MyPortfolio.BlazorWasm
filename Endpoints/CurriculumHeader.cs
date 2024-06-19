using MyPortfolio.BlazorWasm.Models;
using MyPortfolio.BlazorWasm.Endpoints.Responses;

namespace MyPortfolio.BlazorWasm.Endpoints
{
    public class CurriculumHeader(IHttpClientFactory httpClientFactory)
    {
        private readonly HttpClient _client = httpClientFactory.CreateClient(WebConfiguration.Name);

        public async Task<Response<Curriculum_Inicio?>> GetAsync()
        {
            try{
                
            }

            catch(Exception ex)
            {

            }

            return null;
        }

    }
}