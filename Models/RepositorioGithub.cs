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
                    Name = "API de gerenciamento de currículos",
                    Description = "Uma API para gerenciar curriculos com funcionalidades de autenticação segura com Identity e geração de curriculos em PDF formatados. Desenvolvido com .NET 6.",
                    Author = "Paulo Sérgio",
                    Link = "https://github/CsPauloNoob/MyPortfolio"

                },                

                new RepositorioGithub
                {
                    Id = 1,
                    Name = "mini-ERP de gerenciamento escolar",
                    Description = "Sistema pequeno de gerenciamento escolar. Aplicação de console com autenticação e acesso a dados. Atualmente rodando com .NET 8",
                    Author = "Os-Derivados",
                    Link = "https://github/Os-Derivados/college-management"
                    
                },

                new RepositorioGithub
                {
                    Id = 1,
                    Name = "Site de exposição de currículo e portfólio",
                    Description = "Site para expor curriculo e portfólio, desenvolvido com Blazor Web Asembly e C#.",
                    Author = "Paulo Sérgio",
                    Link = "https://github/CsPauloNoob/MyPortfolio.BlazorWasm"

                }
            };

            return repositorios;
        }
    }
}
