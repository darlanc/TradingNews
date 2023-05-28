using MongoDB.Bson.Serialization.Attributes;

namespace TradingNews.Core.Models
{
    public class NewsItem
    {
        /* SAMPLE RESPONSE FROM POLYGON.IO
         {
            "id": "059_uFOsSY28JykDJwgT2u45xraZWZjXDd_mjcMR4rs",
            "publisher": {
                "name": "GlobeNewswire Inc.",
                "homepage_url": "https://www.globenewswire.com",
                "logo_url": "https://s3.polygon.io/public/assets/news/logos/globenewswire.svg",
                "favicon_url": "https://s3.polygon.io/public/assets/news/favicons/globenewswire.ico"
            },
            "title": "InterDigital’s Doug Castor Re-Elected as Vice Chair of the ATIS Next G Alliance National 6G Roadmap Working Group",
            "author": "InterDigital, Inc.",
            "published_utc": "2023-05-08T08:00:00Z",
            "article_url": "https://www.globenewswire.com/news-release/2023/05/08/2663013/24691/en/InterDigital-s-Doug-Castor-Re-Elected-as-Vice-Chair-of-the-ATIS-Next-G-Alliance-National-6G-Roadmap-Working-Group.html",
            "tickers": [
                "IDCC"
            ],
            "amp_url": "https://www.globenewswire.com/news-release/2023/05/08/2663013/24691/en/InterDigital-s-Doug-Castor-Re-Elected-as-Vice-Chair-of-the-ATIS-Next-G-Alliance-National-6G-Roadmap-Working-Group.html",
            "image_url": "https://ml.globenewswire.com/Resource/Download/115dd536-9cf0-4773-92c1-c469a187e357",
            "description": "WILMINGTON, Del., May  08, 2023  (GLOBE NEWSWIRE) -- InterDigital, Inc. (Nasdaq: IDCC), a mobile and video technology research and development company, announced the re-election of Doug Castor, InterDigital’s Head of Wireless Research, to continue a second term as Vice Chair of the ATIS Next G Alliance National 6G Roadmap Working Group.",
            "keywords": [
                "Management Changes"
            ]
        }
         */

        [BsonId]
        public string? Id { get; set; }

        public NewsPublisher? Publisher { get; set; }

        [BsonElement("Title")]
        public string? Title { get; set; }

        [BsonElement("Author")]
        public string? Author { get; set; }

        [BsonElement("PublishedUtc")]
        public DateTime PublishedUtc { get; set; }

        public string? ArticleUrl { get; set; }
        public List<string>? Tickers { get; set; }
        public string? AmpUrl { get; set; }
        public string? ImageUrl { get; set; }

        [BsonElement("Description")]
        public string? Description { get; set; }
        public List<string>? Keywords { get; set; }
        public List<string>? Tags { get; set; }
    }
}
