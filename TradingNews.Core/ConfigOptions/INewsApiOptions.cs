using System;

namespace TradingNews.Core.ConfigOptions
{
    public interface INewsApiOptions
    {
        public string? Key { get; set; }
        public string? Url { get; set; }
        public int Limit { get; set; }
        public string? Sort { get; set; }
        public string? Order { get; set; }
    }
}
