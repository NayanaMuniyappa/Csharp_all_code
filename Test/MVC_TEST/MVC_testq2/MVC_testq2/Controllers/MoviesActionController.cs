using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using MVC_testq2.Models;


namespace MVC_testq2.Controllers
{
    public class MoviesActionController : Controller
    {
        // MoviesController.cs

        public MovieContext _context = new MovieContext();
            public ActionResult Index()
            {
            var movies = _context.dbmov.ToList();
            return View(movies);
            }

            [HttpGet]
            public ActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Create(Movie movie)
            {
                _context.dbmov.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            [HttpGet]
            public ActionResult Edit(int id)
            {
                var movie = _context.dbmov.Find(id);
                return View(movie);
            }

            [HttpPost]
            public ActionResult Edit(Movie movie)
            {
                _context.dbmov.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            public ActionResult Delete(int id)
            {
                var movie = _context.dbmov.Find(id);
                _context.dbmov.Remove(movie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

    }
