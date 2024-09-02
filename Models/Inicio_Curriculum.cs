using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.BlazorWasm.Models
{
    public class Inicio_Curriculum
    {
        //public Inicio_Curriculum()
        //{
        //    Nome = "Capô de Fusca da Silva";
        //    PerfilProgramador = "Com certeza";
        //    SobreMim = "Várias coisas";
        //    DataCriacao = DateTime.Now;
        //}

        [Required]
        [StringLength(70, MinimumLength = 10, ErrorMessage = "Nome deve ter entre 10 e 70 caracteres.")]
        public string Nome { get; set; }

        [MaxLength(15, ErrorMessage = "Função deve conter no máximo 15 caracteres")]
        public string? PerfilProgramador { get; set; }

        [MaxLength(1800, ErrorMessage = "Sobre mim deve conter no máximo 1800 caracteres")]
        public string? SobreMim { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}