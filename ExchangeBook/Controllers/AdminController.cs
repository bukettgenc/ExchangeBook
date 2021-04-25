using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExchangeBook.Models;
namespace ExchangeBook.Controllers
{
    public class AdminController : Controller
    {
        Context db = new Context();
        public IActionResult Admin()
        {
            List<Opinion> opinions = db.Opinions.Where(x => x.Published == false).ToList();
            ViewBag.Opinions = opinions;
            return View();
        }
        public IActionResult Approve(int id)
        {
          var approve=  db.Opinions.Where(x => x.OpinionId == id).SingleOrDefault();
            approve.Published = true;
            db.SaveChanges();

            return Redirect("~/Admin/Admin/");
        }
        public void Delete(int id)
        {
           
        }
    }
}
