using ExchangeBook.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ExchangeBook.Controllers
{
    public class LoginController : Controller
    {
        Context db = new Context();
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            var bilgiler = db.Users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            if (bilgiler != null)
            {
                var claims = new List<Claim> {
                new Claim(ClaimTypes.Name,user.UserName)};
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return Redirect("~/Home/Index/" + bilgiler.UserId);
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");
        }
        public IActionResult Register()
        {
            List<SelectListItem> values = (from x in db.Cities.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CityName,
                                               Value = x.CityId.ToString()
                                           }).ToList();
            ViewBag.values = values;
            return View();

        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            var item = db.Users.Where(x => x.UserName == user.UserName || x.Email == user.Email).SingleOrDefault();
            if (user.Password == user.Password2 && item == null)
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
            return Redirect("~/Login/Login/");
            
        }
    }
}
