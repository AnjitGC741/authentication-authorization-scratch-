using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace authentication_authorization_scratch_.Controllers
{
    public class CustomerController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
