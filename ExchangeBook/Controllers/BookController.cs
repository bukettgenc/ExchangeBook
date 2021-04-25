using ExchangeBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using java.nio.file;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ExchangeBook.Controllers
{
    [Authorize] 
    public class BookController : Controller
    {
        Context db = new Context();
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public IActionResult AddBook(int id)
        {
            List<SelectListItem> values = (from x in db.BookTypes.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.TypeName,
                                               Value = x.TypeId.ToString()
                                           }).ToList();
            ViewBag.values = values;
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(int id, MyBook book)
        {
            book.BookImage = "img";
            book.UserId = id;
            ViewBag.Id = id;

            db.MyBooks.Add(book);
            db.SaveChanges();
            //if (file != null && file.ContentLength > 0)
            //    try
            //    {
            //        String random = RandomString(10);
            //       string path = Path.Combine(Server.MapPath("~/Upload/"),
            //        Path.GetFileName(random + ".mp4"));
            //        file.SaveAs(path);
            //        book.BookImage = "~/Upload/" + random + ".mp4";
            //        ViewBag.Message = "File uploaded successfully";
            //    }
            //    catch (Exception ex)
            //    {
            //        ViewBag.Message = "ERROR:" + ex.Message.ToString();
            //    }
            //else
            //{
            //    ViewBag.Message = "You have not specified a file.";
            //}
            return Redirect("~/Home/Profile/" + id);
        }
    }
}
