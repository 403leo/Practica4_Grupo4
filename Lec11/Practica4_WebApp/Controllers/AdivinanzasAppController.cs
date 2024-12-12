using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica4_WebApp.Controllers
{
    public class AdivinanzasAppController : Controller
    {
        // GET: AdivinanzasApp
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdivinanzasApp/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdivinanzasApp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdivinanzasApp/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdivinanzasApp/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdivinanzasApp/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdivinanzasApp/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdivinanzasApp/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
