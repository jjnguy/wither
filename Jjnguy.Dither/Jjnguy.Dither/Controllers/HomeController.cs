using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace Jjnguy.Dither.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("img")]
        public IActionResult Img()
        {
            return File(new HttpClient().GetAsync("https://i.redd.it/k4ro1qrip7r21.jpg").Result.Content.ReadAsByteArrayAsync().Result, "img/jpg");
        }
    }
}
