using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.BlazorWasm.Models
{
    public class Contato
    {

        public string? Email { get; set; }
        public string? Rua { get; set; }
        public string? Bairro { get; set; }
        public string? NumeroCasa { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Codigo { get; set; }
        public string? DDD { get; set; }
        public string? NumeroTelefone_Celular { get; set; }   
    }
}