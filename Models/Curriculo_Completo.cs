namespace MyPortfolio.BlazorWasm.Models
{

    # pragma warning disable

    //Os nomes das propriedades foram alterados para atender o corpo da requisição 
    //pedido pela API

    public class Curriculo_Completo
    {
        public Inicio_Curriculum Header { get; set; } = new();

        public Contato Contato { get; set; } = new();

        public List<CursosExtraModel> Cursos_Extra { get; set; } = new();

        public List<EducacaoModel> Formacao { get; set; } = new();

        public List<Experiencia> ExpProfissional { get; set; } = new();

        public List<Habilidades> Habilidades {get; set;} = new();
    }
}