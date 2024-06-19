using System.Text.Json.Serialization;

namespace MyPortfolio.BlazorWasm.Endpoints.Responses
{
    public class Response<TData>
    {
        private int _code = WebConfiguration.DefaultStatusCode;

        [JsonConstructor]
        public Response()
            => _code = WebConfiguration.DefaultStatusCode;
        
        public Response(
            TData? data,
            int code = WebConfiguration.DefaultStatusCode,
            string? message = null)
        {
            Data = data;
            _code = code;
            Message = message;
        }

        public TData? Data { get; set; }
        public string? Message { get; set; }

        [JsonIgnore]
        public bool IsSuccess => _code is >= 200 and <= 299;
    }
}