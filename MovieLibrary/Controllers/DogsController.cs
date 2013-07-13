using System;
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

        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name);
            throw new Exception("Hi");
            return File(Server.MapPath("~/Content/site.css"), "text/css");
        }

    }
}
