using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.BlazorWasm.Models
{
    public class Experiencia
    {
        //public Experiencia()
        //{
        //    Nome_Organizacao = "Bradesco";
        //    Funcao = "CEO";
        //    Descricao = "Era o CEO ué";
        //}

        [Required]
        [MaxLength(40)]
        public string Nome_Organizacao { get; set; }
        [Required]
        [MaxLength(50)]
        public string Funcao { get; set; }
        [MaxLength(300)]
        public string Descricao { get; set; }
    }
}