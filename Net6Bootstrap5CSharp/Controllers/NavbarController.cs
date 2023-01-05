using Microsoft.AspNetCore.Mvc;

namespace Net6Bootstrap5CSharp.Controllers
{
    public class NavbarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
