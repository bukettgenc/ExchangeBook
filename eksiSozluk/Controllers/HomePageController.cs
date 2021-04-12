using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eksiSozluk.Models;
using Microsoft.AspNetCore.Hosting.Internal;

namespace eksiSozluk.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult HomePage()
        {
            Context db=new Context();
            List<HomePage> homePageList=db.HomePages.ToList();
            ViewBag.listem = homePageList;
            return View();
        }
        //public IActionResult kayıtol()
        //{
        //    return View();
        //}
        //public IActionResult HomePage()
        //{
        //    return View();
        //}
    }
}
