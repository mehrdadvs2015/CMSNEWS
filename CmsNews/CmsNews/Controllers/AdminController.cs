﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CmsNews.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult HomePage()
        {
            return View();
            //test project in home
        }
    }
}