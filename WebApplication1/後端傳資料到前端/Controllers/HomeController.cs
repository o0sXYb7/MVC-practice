using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using 後端傳資料到前端.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 後端傳資料到前端.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DateTime date = DateTime.Now;
            ViewBag.Date = date;

            Student data = new Student("1", "小明", 80);
            return View(data);
        }
    }
}