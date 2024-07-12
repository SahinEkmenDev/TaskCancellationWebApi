using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskCancelationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public  class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> logger;

        public HomeController( ILogger<HomeController> logger)
        {
            this.logger = logger;
        }


        [HttpGet]
        public async  Task<IActionResult> GetActionResultAsync()
        {
            logger.LogInformation("istek  başladı ");

            Thread.Sleep(3000);
            var mytask = new HttpClient().GetStringAsync("https://www.youtube.com");
            var  data = mytask.Result;

            logger.LogInformation("istek bitti");
            return Ok(data);
        }
    }
}
