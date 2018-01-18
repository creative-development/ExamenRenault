using MVCEscolarV1.Models;
using MVCEscolarV1.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEscolarV1.Controllers
{
    public class MateriasController : Controller
    {
        private EscolarMateriasRepositorio _repo;
        public MateriasController()
        {
            _repo = new EscolarMateriasRepositorio();
        }
        // GET: Materias
        public ActionResult Index()
        {
            var model = _repo.TodasMaterias();
            return View();
        }

        // GET: Materias/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Materias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Materias/Create
        [HttpPost]
        public ActionResult Create(Materias model)
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

        // GET: Materias/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Materias/Edit/5
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

        // GET: Materias/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Materias/Delete/5
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
