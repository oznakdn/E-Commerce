using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.WebMvc.Areas.Customer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
