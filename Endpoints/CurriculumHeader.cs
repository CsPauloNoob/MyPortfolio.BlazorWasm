using MyPortfolio.BlazorWasm.Models;
using MyPortfolio.BlazorWasm.Endpoints.Responses;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace MyPortfolio.BlazorWasm.Endpoints
{
    public class CurriculumHeader(IHttpClientFactory httpClientFactory)
    {
        private readonly HttpClient _client = httpClientFactory.CreateClient(WebConfiguration.Name);



        public async Task<Response<Inicio_Curriculum?>> GetAsync()
        {
            try
            {
                //Codigo de teste

                /*var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoicGFibG8iLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6ImEzNzM3ZDNjLTFiNDctNGRhZi04NjhlLTU2YTkyMjgzYTYwMSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2VtYWlsYWRkcmVzcyI6InN0cmluZyIsImp0aSI6InN0cmluZyIsImV4cCI6MTcyMzc4MzM1N30.fyI2_koJp1l0724keKidc0wlhIzf-OfiJxgqLWlZ4Z4";
                var url = _client.BaseAddress + "/curriculum";

                var auth = new AuthenticationHeaderValue("Bearer", token);

                _client.DefaultRequestHeaders.Authorization = auth;

                var responseObjeto = await _client.GetFromJsonAsync<Inicio_Curriculum>(url);

                responseObjeto.Nome = string.Empty; */

                var url = _client.BaseAddress + "/endpoints/htu";

                var response = await _client.GetAsync(url);

                response = null;

            }

            catch(Exception ex)
            {
                //configurar CORS
            }

            return null;
        }

    }
}