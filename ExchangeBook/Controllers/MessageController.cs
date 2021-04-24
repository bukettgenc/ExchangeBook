using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeBook.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        public IActionResult WriteMessage(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        public IActionResult MyMessage(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}
