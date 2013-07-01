using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MovieLibrary.Models;

namespace MovieLibrary.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext db = new MovieContext();
        //
        // GET: /Home/

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }
        public ActionResult About()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Movie movieToCreate)
        {
            try
            {
                db.Movies.Add(movieToCreate);
                db.SaveChanges();

                return RedirectToAction("Index");

            }
            catch
            {

                return View();
            }
        }

        public ActionResult Delete(int id = 0)
        {
            Movie movie = db.Movies.Find(id);
            if (movie != null)
            {
                db.Movies.Remove(movie);
                db.SaveChanges();
            }
            return RedirectToAction("index");
        }

        public ActionResult Edit(int id = 0)
        {
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }



        //
        // POST: /Movies/Edit/5

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
    }
}
