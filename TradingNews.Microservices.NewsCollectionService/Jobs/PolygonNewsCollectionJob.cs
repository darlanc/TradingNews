using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using TradingNews.Core.ConfigOptions;
using TradingNews.Core.Models;
using TradingNews.Core.ServiceContracts;

namespace TradingNews.Microservices.NewsCollectionService.Jobs
{
    public class PolygonNewsCollectionJob
    {
        private readonly INewsService _newsService;
        private readonly INewsApiOptions _options;
        private readonly ILogger<PolygonNewsCollectionJob> _logger;

        private HttpClient _httpClient;

        public PolygonNewsCollectionJob(INewsService newsService, INewsApiOptions options, ILogger<PolygonNewsCollectionJob> logger)
        {
            _newsService = newsService;
            _options = options;
            _logger = logger;
            _httpClient = new HttpClient();
        }

        public async Task ExecuteAsync()
        {
            _logger.LogInformation("PolygonNewsCollectionJob.ExecuteAsync() started");
            var polygonResponse = await GetNews();
            if (polygonResponse.status == "OK" && polygonResponse.results != null)
            {
                _logger.LogInformation($"PolygonNewsCollectionJob.ExecuteAsync() found {polygonResponse.count} news items");
                await AddNews(polygonResponse.results);
            }
            else
            {
                _logger.LogError($"PolygonNewsCollectionJob.ExecuteAsync() failed with status {polygonResponse.status}");
            }
        }

        private async Task AddNews(IEnumerable<NewsItem> news)
        {
            foreach (var newsItem in news)
            {
                try
                {
                    var item = await _newsService.GetAsync(newsItem!.Id!);
                    if (item != null)
                        continue;
                    await _newsService.CreateAsync(newsItem);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, ex.Message);
                }
            }
        }

        private async Task<PolygonResponse> GetNews()
        {
            var url = $"{_options.Url}?limit={_options.Limit}&order={_options.Order}&sort={_options.Sort}&apiKey={_options.Key}";
            var response = await _httpClient.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            var polygonResponse = JsonConvert.DeserializeObject<PolygonResponse>(result);
            return polygonResponse;
        }

        private class PolygonResponse
        {
            public string? status { get; set; }
            public int? count { get; set; }
            public string? request_id { get; set; }
            public List<NewsItem>? results { get; set; }
        }
    }
}
