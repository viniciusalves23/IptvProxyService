using Microsoft.AspNetCore.Mvc;

namespace IptvProxyService.Controllers
{
    public class StreamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
