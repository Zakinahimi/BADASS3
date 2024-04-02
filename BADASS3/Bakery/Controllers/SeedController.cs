using Bakery.Database;
using Bakery.Model;
using Microsoft.AspNetCore.Mvc;



namespace Bakery.Controllers
{
    public class SeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
