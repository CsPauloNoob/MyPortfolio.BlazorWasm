using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.BlazorWasm.Models
{
    public class Habilidades
    {
        [Required]
        [MaxLength(35)]
        public string Nome_Habilidade { get; set; }

        [MaxLength(180)]
        public string? Descricao { get; set; }
    }
}