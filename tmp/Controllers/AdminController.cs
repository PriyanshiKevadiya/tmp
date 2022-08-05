using Microsoft.AspNetCore.Mvc;

namespace tmp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
