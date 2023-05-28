using Microsoft.Extensions.DependencyInjection;
using TradingNews.Core.ServiceContracts;

namespace TradingNews.Microservices.DataStorageService
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDataServices(this IServiceCollection services)
        {
            services.AddScoped<INewsService, NewsService>();
        }
    }
}
