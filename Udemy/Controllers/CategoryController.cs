using Microsoft.AspNetCore.Mvc;

namespace Udemy.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
