using System;

namespace TradingNews.Core.ConfigOptions
{
    public interface IDbOptions
    {
        string? ConnectionString { get; set; }
        string? DatabaseName { get; set; }
        string? NewsCollectionName { get; set; }
    }
}
