﻿using SportProf.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportProf.Controllers
{
    [Culture]
    public class ErrorController : Controller
    {
        public ActionResult NotFound()
        {
            return View();
        }
    }
}