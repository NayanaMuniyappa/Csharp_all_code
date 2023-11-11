using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data;
using MVC_TEST_2.Models;

namespace MVC_TEST_2.Controllers
{
    public class CrudController : Controller
    {
        db con = new db();

        //Read
        public ActionResult Index()
        {
            var item = con.mov.ToList();
           
            return View(item);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movies mov)
        {
            con.mov.Add(mov);
            con.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}