using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TradingNews.Core.ServiceContracts;

namespace TradingNews.WebAPI.Controllers
{
    [ApiController]
    [Route("api/news")]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        [AllowAnonymous] // TODO: Remove this attribute when authentication is implemented
        public IActionResult Get() => Ok(_newsService.GetAsync().Result); // TODO: Add pagination support
    }
}
