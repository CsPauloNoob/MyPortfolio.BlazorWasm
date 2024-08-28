using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.BlazorWasm.Models
{
    public class CursosExtraModel
    {
        //public CursosExtraModel()
        //{
        //    Nome_Curso = "Curso de finanças";
        //    Organizacao = "Tabajara";
        //}


        [Required]
        [MaxLength(35)]
        public string Nome_Curso { get; set; }

        [MaxLength(35)]
        public string Organizacao { get; set; }
    }
}
