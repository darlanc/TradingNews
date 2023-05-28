using TradingNews.Core.ConfigOptions;

namespace TradingNews.Microservices.NewsCollectionService.Polygon.io
{
    public class PolygonOptions : INewsApiOptions
    {
        public string? Key { get; set; }
        public string? Url { get; set; }
        public int Limit { get; set; }
        public string? Sort { get; set; }
        public string? Order { get; set; }
    }
}
