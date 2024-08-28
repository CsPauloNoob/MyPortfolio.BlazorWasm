using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.BlazorWasm.Models
{
    public class EducacaoModel
    {

        //public EducacaoModel()
        //{
        //    Instituicao = "Von Swaftz Milhares";
        //    Curso = "A";
        //    AnoConclusao = "2020";
        //}

        [MaxLength(30)]
        public string Instituicao { get; set; }

        [MaxLength(50)]
        public string Curso { get; set; }

        [MaxLength(4)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Ano de conclusão deve conter somente números.")]
        public string AnoConclusao { get; set; }
    }
}