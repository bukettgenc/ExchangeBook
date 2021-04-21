using ExchangeBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeBook.Controllers
{
    public class HomeController : Controller
    {
        Context db=new Context();
        public IActionResult Index(int id)
        {
            List<MyBook> bookList=db.MyBooks.Where(x => x.UserId != id && x.IsDeleted==false).ToList();
            ViewBag.bookList = bookList;
            return View();
        }
        public IActionResult Profile(int id)
        {
            List<MyBook> bookList = db.MyBooks.Where(x => x.UserId == id && x.IsDeleted == false).ToList();
            ViewBag.bookList = bookList;
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
