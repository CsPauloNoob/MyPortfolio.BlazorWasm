using MyPortfolio.BlazorWasm.Endpoints.Responses;
using MyPortfolio.BlazorWasm.Models;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyPortfolio.BlazorWasm.Endpoints
{
    public class CurriculumPdf(IHttpClientFactory httpClientFactory)
    {
        private readonly HttpClient _client = httpClientFactory.CreateClient(WebConfiguration.Name);

        public async Task<string> GetPauloPdf()
        {
            try
            {
                var url = _client.BaseAddress + "/pdfgen/owner";

                
                var response = await _client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var pdfBytes = await response.Content.ReadAsByteArrayAsync();
                    var base64String = Convert.ToBase64String(pdfBytes);


                    return base64String;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return string.Empty;
        }


    }
}