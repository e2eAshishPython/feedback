using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class feedbackController : Controller
    {
        //// GET: feedback
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: feedback/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: feedback/Create
        public ActionResult Create()
        {
            return View("Createfeedback");
        }

        // POST: feedback/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Modelfeedback modelfeedback)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(thankYou));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult thankYou()
        {
            return View();
        }

        // GET: feedback/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: feedback/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: feedback/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: feedback/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}