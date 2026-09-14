using Microsoft.AspNetCore.Mvc;

namespace Permission.WebAPI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
