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
    
        public IActionResult MyFav(int id)
        {
            List<MyFav> list = db.MyFavs.Where(x => x.UserId==id).ToList();
            List<MyBook> favList=new List<MyBook>();
            foreach (var item in list)
            {
                MyBook book = db.MyBooks.Where(t => t.BookId == item.BookId).SingleOrDefault();
                favList.Add(book);
            }
            ViewBag.FavList = favList;

            return View();
        }
        public IActionResult GiveYourOpinion()
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
