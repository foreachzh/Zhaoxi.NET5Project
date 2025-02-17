﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Zhaoxi.NET5Project.Models;
using Zhaoxi.NET5Project.Web.Interface;

namespace Zhaoxi.NET5Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceB serviceB;

        public HomeController(IServiceB serviceB,ILogger<HomeController> logger)
        {
            this.serviceB = serviceB;
            this._logger = logger;
        }

        public IActionResult Index()
        {
            base.ViewData["User1"] = "张三-1发布新版本V0.0.3";
            base.TempData["User2"] = "李四-好了吗？";
            base.ViewBag.User3 = "王五-成功了吗？";
            object User4 = "赵六333";
            return View(User4);
        }

        public IActionResult First()
        {
            serviceB.CallServiceA();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
