using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeBook.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult WriteMessage()
        {
            return View();
        }
    }
}
