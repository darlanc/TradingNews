using TradingNews.Core.ConfigOptions;

namespace TradingNews.Microservices.DataStorageService
{
    public class DbOptions : IDbOptions
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public string? NewsCollectionName { get; set; }
    }
}