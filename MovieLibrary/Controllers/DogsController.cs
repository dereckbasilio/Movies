﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieLibrary.Controllers
{
    public class DogsController : Controller
    {
        //
        // GET: /Dogs/

        public ActionResult Search()
        {
            return Content("Hello!");
        }

    }
}