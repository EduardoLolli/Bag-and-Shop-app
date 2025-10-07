using Microsoft.AspNetCore.Mvc;

namespace Bag_and_Shop_app.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
