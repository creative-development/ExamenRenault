using MVCEscolarV1.Models;
using MVCEscolarV1.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEscolarV1.Controllers
{
    public class AlumnosController : Controller
    {
        private EscolarAlumnosRepositorio _repo;
        public AlumnosController()
        {
            _repo = new EscolarAlumnosRepositorio();
        }
        // GET: Alumnos
        public ActionResult Index()
        {
            var model = _repo.TodosAlumnos();
            return View(model);
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(Alumnos model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _repo.Crear(model);
                    return RedirectToAction("Index");
                }

               
            }
            catch
            {
                return View();
            }
            return View(model);
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Alumnos/Edit/5
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

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Alumnos/Delete/5
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
