using MyPortfolio.BlazorWasm.Endpoints;

namespace MyPortfolio.BlazorWasm.Extensions
{
    public static class DependencyInjection
    {
        public static void injectDependences(this IServiceCollection services)
        {
            services.AddTransient<CurriculumHeader>();
        }
    }
}
