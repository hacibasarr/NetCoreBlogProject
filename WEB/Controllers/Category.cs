using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
