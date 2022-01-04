using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bán_Hàng_Onl_WebForm.Models;

namespace Bán_Hàng_Onl_WebForm.Controllers
{
    public class CatelogyController : Controller
    {
        // GET: Catelogy
        public ActionResult Index()
        {
            var iplCate = new CatModel();
            var model = iplCate.ListProduct();
            return View(model);
        }

        // GET: Catelogy/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Catelogy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catelogy/Create
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

        // GET: Catelogy/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Catelogy/Edit/5
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

        // GET: Catelogy/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Catelogy/Delete/5
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
