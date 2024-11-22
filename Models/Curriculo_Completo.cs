namespace MyPortfolio.BlazorWasm.Models
{

    # pragma warning disable

    //Os nomes das propriedades foram alterados para atender o corpo da requisição 
    //pedido pela API

    public class Curriculo_Completo
    {
        public Inicio_Curriculum header { get; set; } = new();

        public Contato contato { get; set; } = new();

        public List<Habilidades> habilidades { get; set; } = new();

        public List<CursosExtraModel?> cursos_Extra { get; set; } = new();

        public List<EducacaoModel?> formacao { get; set; } = new();

        public List<Experiencia?> expProfissional {get; set;} = new();
    }
}