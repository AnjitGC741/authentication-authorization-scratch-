using Microsoft.AspNetCore.Mvc;

namespace authentication_authorization_scratch_.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
