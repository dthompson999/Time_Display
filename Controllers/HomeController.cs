using Microsoft.AspNetCore.Mvc;
namespace time_display
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}