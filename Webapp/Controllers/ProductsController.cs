using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int Id)
        {
            return View(Id);
        }
    }
}
