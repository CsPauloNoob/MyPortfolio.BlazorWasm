namespace MyPortfolio.BlazorWasm.Models
{
    public class RepositorioGithub
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public string Link { get; set; } = string.Empty;


        public List<RepositorioGithub> DefaultProjetos()
        {
            List<RepositorioGithub> repositorios = new List<RepositorioGithub>()
            {
                new RepositorioGithub
                {
                    Id = 0,
                    Name = "API de gerenciamento escolar",
                    Description = "API de gerenciamento escolar. Desenvolvido em .NET 6, sistema conta com separação de camadas e autenticação de usuário com Identity",
                    Author = "Paulo Sérgio",
                    Link = "https://google.com"

                },                

                new RepositorioGithub
                {
                    Id = 1,
                    Name = "API de gerenciamento escolar",
                    Description = "API de gerenciamento escolar. Desenvolvido em .NET 6, sistema conta com separação de camadas e autenticação de usuário com Identity",
                    Author = "Paulo Sérgio",
                    Link = "https://google.com"
                    
                }
            };

            return repositorios;
        }
    }
}
