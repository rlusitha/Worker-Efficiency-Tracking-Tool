using Microsoft.AspNetCore.Mvc;

namespace Personal_Project.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
