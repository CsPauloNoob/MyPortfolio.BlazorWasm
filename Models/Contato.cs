using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.BlazorWasm.Models
{

    #pragma warning disable

    public class Contato
    {

        public Contato()
        {
            //Email = "Email@gov.br";
            //Email = "www.linkedin.com";
            //Rua = "Rua foi de exemplo";
            //Bairro = "Dom CArlos 8�";
            //NumeroCasa = "22";
            //Cidade = "Ponta Grossa";
            //Estado = "MG";
            //Codigo = "+55";
            //DDD = "99";
            //NumeroTelefone_Celular = "22233344";
        }

        [Required]
        public string Email { get; set; }

        [MaxLength(30)]
        public string? LinkedIn { get; set; }

        [Range(3, 50)]
        public string Rua { get; set; }

        [MaxLength(50)]
        public string Bairro { get; set; }

        [MaxLength(7)]
        public string NumeroCasa { get; set; }

        [MaxLength(30)]
        public string Cidade { get; set; }

        [MaxLength(2)]
        public string Estado { get; set; }

        //Retirar daqui e auto preencher na hora de salvar no banco. C�digo se refere ao c�digo brasileiro de telefone +55.
        [MaxLength(3)]
        public string Codigo { get; set; }

        [MaxLength(2)]
        public string DDD { get; set; }

        [MaxLength(10)]
        public string NumeroTelefone_Celular { get; set; }
    }
}