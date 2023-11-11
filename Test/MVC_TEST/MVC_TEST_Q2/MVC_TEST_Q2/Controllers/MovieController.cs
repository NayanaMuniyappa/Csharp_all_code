using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_TEST_Q2.Models;

namespace MVC_TEST_Q2.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        IMovie _Mov = null;
        public MovieController()
        {
            _Mov = new Repository();
        }
        public ActionResult Index()
        {
            var p = _Mov.getall();
            return View(p);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Movie obj)
        {
            if (ModelState.IsValid)
            {
                _Mov.insert(obj);
                _Mov.save();
                return RedirectToAction("Index");
            }
            else
                return RedirectToAction("Index");

        } 

        
        public ActionResult edit(int obj)
        {
            var v = _Mov.getbyid(obj);
            return View();

        }
        [HttpPost]
         public ActionResult edit(Movie obj)
        {
            if(ModelState.IsValid)
            {
                _Mov.update(obj);
                _Mov.save();
                return RedirectToAction("Index");

            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult Delete(int id)
        {
            Movie m = new Movie();
            m.mid = id;
            var v = _Mov.getbyid(m);
            return View(v);
        }
         
        [HttpPost]
       public ActionResult Delete(Movie obj)
        {
            if(ModelState.IsValid)
            {
                _Mov.delete(obj);
                _Mov.save();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }


    }
}