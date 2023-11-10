using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_TEST_2.Models;
using MVC_TEST_2.Models.Movies;

namespace MVC_TEST_2.Controllers

{
    public class MoviesController : Controller
    {
        Model1 con = new Model1();
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movies movie)
        {
            con.Movies.Add(movie);
            con.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var movie = con.Movies.Find(id);
            return View(movie);
        }



        [HttpPost]
        public ActionResult Delete(int id)
        {
            var movie = con.Movies.Find(id);
            if (movie != null)
            {
                con.Movies.Remove(movie);
                con.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult MoviesByYear(int year)
        {
            var movies = con.Movies.Where(m => m.DateOfRelease.Year == year).ToList();
            return View(movies);
        }
    }
}

