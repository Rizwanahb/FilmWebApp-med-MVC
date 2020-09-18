using FilmWebApp_med_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FilmWebApp_med_MVC.Controllers
{
    public class HomeController : Controller
    {
        private FilmEntities _db = new FilmEntities();
        // GET: Film
        public ActionResult Index()
        {
            return View(_db.Film_Nomineringer.ToList());
        }

        // GET: Film/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Message = "Your movie description page.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    } }
        //.......................................................................................................................



        //// GET: Film/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Film/Create
        //[HttpPost]
        //public ActionResult Create([Bind(Exclude ="Id")] Film_Nomineringer filmtocreate)
        //{
        //    if (!ModelState.IsValid)
        //        return View();
        //    _db.Film_Nomineringer.Add(filmtocreate);
        //    _db.SaveChanges();

        //    return RedirectToAction("Index");

        //}

        // GET: Film/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Film/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Film/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Film/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
  