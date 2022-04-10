using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.WebMvc.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
