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

namespace ExchangeBook.Controllers
{
    [Authorize] 
    public class BookController : Controller
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public IActionResult AddBook(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(int id, MyBook book)
        {
            //if (file != null && file.ContentLength > 0)
            //    try
            //    {
            //        String random = RandomString(10);
            //        string path = Path.Combine(
            //                       Directory.GetCurrentDirectory(), "wwwroot", file.GetFilename(),
            //                         Path.GetFileName(random + ".jpg"));
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
            ViewBag.Id = id;
            return View();
        }
    }
}
