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
        Context db = new Context();
        public IActionResult Index(int id, string book,string author,string type)
        {
            var degerler = from d in db.MyBooks select d;
            if (!string.IsNullOrEmpty(book) || !string.IsNullOrEmpty(author) || !string.IsNullOrEmpty(author))
            {
                degerler = degerler.Where(m => m.BookName.Contains(book) || m.BookAuthor.Contains(author) || m.TypeName.Contains(type));
            }
            List<MyBook> bookList = db.MyBooks.Where(x => x.UserId != id && x.IsDeleted == false).ToList();
            ViewBag.bookList = bookList;
            ViewBag.Id = id;

            return View(degerler.ToList());
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
        public IActionResult UserProfile(int id, int userId)
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
            List<MyFav> list = db.MyFavs.Where(x => x.UserId == id).ToList();
            List<MyBook> favList = new List<MyBook>();
            foreach (var item in list)
            {
                MyBook book = db.MyBooks.Where(t => t.BookId == item.BookId).SingleOrDefault();
                favList.Add(book);
            }
            List<MyFav> list2 = db.MyFavs.ToList();

            ViewBag.FavList = favList;
            ViewBag.FavList2 = list2;
            ViewBag.Id = id;

            return View();
        }
        [Authorize]
        public IActionResult GiveYourOpinion(int id)
        {
            ViewBag.Id = id;

            return View();
        }
        [HttpPost]
        public IActionResult GiveYourOpinion(int id, Opinion opinion)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("~/Home/GiveYourOpinion/" + id);
            }
            opinion.UserId = id;
            opinion.Published = false;
            db.Opinions.Add(opinion);
            db.SaveChanges();
            ViewBag.Id = id;

            return View();
        }
        public IActionResult Information(int id)
        {
            ViewBag.Id = id;

            return View();
        }
        [HttpPost]
        public JsonResult AddFav(int id, int bookId)
        {
            var favList = db.MyFavs.ToList();
            string buttonName = "";
            if (favList.Exists(x => x.BookId == bookId && x.UserId == id))
            {
                var item = db.MyFavs.Where(x => x.BookId == bookId && x.UserId == id).SingleOrDefault();
                db.MyFavs.Remove(item);
                buttonName = "Favorilere Ekle";
            }
            else
            {
                MyFav fav = new MyFav();
                fav.BookId = bookId;
                fav.UserId = id;
                db.MyFavs.Add(fav);
                buttonName = "Favorilerden Kaldır";


            }
            db.SaveChanges();

            MoveAjax m = new MoveAjax();
            m.buttonName = buttonName;
            return Json(m);
        }


    }
}
