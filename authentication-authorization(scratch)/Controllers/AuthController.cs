using Microsoft.AspNetCore.Mvc;

namespace authentication_authorization_scratch_.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
