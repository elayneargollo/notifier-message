using Microsoft.Extensions.DependencyInjection;

namespace Comunicacao.Messagem
{
    public static class ServiceProvide
    {
        private static IServiceCollection servicos = new ServiceCollection();
        private static ServiceProvider serviceProvider;

        private static void SetServiceProvider()
        {
            ConfigureServices(servicos);
            serviceProvider = servicos.BuildServiceProvider();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IConfigurationService, ConfigurationService>();
        }
    }
}