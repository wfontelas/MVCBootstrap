using Microsoft.AspNetCore.Mvc;

namespace Net6Bootstrap5CSharp.Controllers
{
    public class ToastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
