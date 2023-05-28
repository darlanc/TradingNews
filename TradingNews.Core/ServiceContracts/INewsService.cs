using TradingNews.Core.Models;

namespace TradingNews.Core.ServiceContracts
{
    public interface INewsService
    {
        Task<List<NewsItem>> GetAsync();
        Task<NewsItem?> GetAsync(string id);
        Task CreateAsync(NewsItem newNewsItem);
        Task UpdateAsync(string id, NewsItem updatedNewsItem);
        Task RemoveAsync(string id);
    }
}
