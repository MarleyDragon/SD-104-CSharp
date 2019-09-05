using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MusicStore1.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Neo...the matrix has you...";
        }
        public IActionResult WhiteRabbit()
        {
            return View();
        }
    }
}