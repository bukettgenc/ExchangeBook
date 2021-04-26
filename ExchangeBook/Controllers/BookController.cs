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
using Microsoft.AspNetCore.Hosting;

namespace ExchangeBook.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        Context db = new Context();
        private IHostingEnvironment hostingEnv;

        public BookController(IHostingEnvironment env)

        {

            this.hostingEnv = env;

        }


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
        public IActionResult AddBook(int id, MyBook book, UploadModel upload)
        {
            String random = RandomString(10);
            var FileDic = "Files";

            string FilePath = System.IO.Path.Combine(hostingEnv.WebRootPath, FileDic);

            if (!Directory.Exists(FilePath))

                Directory.CreateDirectory(FilePath);

            var fileName =random+upload.File.FileName;
           
            var filePath = System.IO.Path.Combine(FilePath, fileName);



            using (FileStream fs = System.IO.File.Create(filePath))

            {

                upload.File.CopyTo(fs);

            }




            if (!ModelState.IsValid)
            {
                return Redirect("~/Book/AddBook/" + id);
            }
            book.BookImage = "~/Files/"+fileName;
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
        public IActionResult Details(int id, int bookId, int person)
        {
            ViewBag.Id = id;
            
            MyBook detail = db.MyBooks.Where(x => x.BookId == bookId && x.UserId == person).SingleOrDefault();
            ViewBag.detail = detail;
            return View();
        }
    }
}
