using System;

namespace TradingNews.Core.Models
{
    public class NewsPublisher
    {
        /* SAMPLE RESPONSE FROM POLYGON.IO
         "publisher": {
                "name": "GlobeNewswire Inc.",
                "homepage_url": "https://www.globenewswire.com",
                "logo_url": "https://s3.polygon.io/public/assets/news/logos/globenewswire.svg",
                "favicon_url": "https://s3.polygon.io/public/assets/news/favicons/globenewswire.ico"
            }
         */
        public string? Name { get; set; }
        public string? HomepageUrl { get; set; }
        public string? LogoUrl { get; set; }
        public string? FaviconUrl { get; set; }
    }
}
