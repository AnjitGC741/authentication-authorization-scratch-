using authentication_authorization_scratch_.Data;
using authentication_authorization_scratch_.Models;
using authentication_authorization_scratch_.Services;
using Microsoft.AspNetCore.Mvc;

namespace authentication_authorization_scratch_.Controllers
{
    public class AuthController : Controller
    {
        public readonly ApplicationDbContext _db;
        public AuthController(ApplicationDbContext db) { 
            _db = db;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var userExist = _db.Users.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
            if(userExist != null)
            {
                var userInfo = new LoggedInUserInfo {
                    Id = userExist.Id,
                    Name = userExist.Name,
                    Email = userExist.Email,
                    UserType = userExist.Usertype,
                    IsSuperAdmin = userExist.Usertype == EnumUserType.Admin
                };
                SessionService.SetSession(userInfo, HttpContext);
                if(userExist.Usertype == EnumUserType.Admin)
                {
                    return RedirectToAction("Index", "Admin");
                }
                return RedirectToAction("Index","Customer");
            }
            return View();
        }
    }
}