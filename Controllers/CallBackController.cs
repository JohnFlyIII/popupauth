using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace popupdemo.Controllers
{
    public class CallBackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}