﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}