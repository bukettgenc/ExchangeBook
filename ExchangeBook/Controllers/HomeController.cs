using ExchangeBook.Models;
using Microsoft.AspNetCore.Authorization;
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
            ViewBag.Id = id;
            return View();
        }
        [Authorize]
        public IActionResult Profile(int id)
        {
            List<MyBook> bookList = db.MyBooks.Where(x => x.UserId == id && x.IsDeleted == false).ToList();
            ViewBag.bookList = bookList;
            ViewBag.Id = id;

            return View();
        }
        [Authorize]
        public IActionResult UserProfile(int id,int userId)
        {
            List<MyBook> bookList = db.MyBooks.Where(x => x.UserId == userId && x.IsDeleted == false).ToList();
            ViewBag.bookList = bookList;
            User user = db.Users.Where(x => x.UserId == userId).SingleOrDefault();
            ViewBag.User = user;
            ViewBag.Id = id;

            return View();
        }
        [Authorize]
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
            ViewBag.Id = id;

            return View();
        }
        [Authorize]
        public IActionResult GiveYourOpinion(int id)
        {
            ViewBag.Id = id;

            return View();
        }

        public IActionResult Information(int id)
        {
            ViewBag.Id = id;

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
