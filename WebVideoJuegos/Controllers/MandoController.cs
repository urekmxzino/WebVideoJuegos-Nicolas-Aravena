using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVideoJuegos.Models;

namespace WebVideoJuegos.Controllers
{
    public class MandoController : Controller
    {
        ModeloBD bd = new ModeloBD();
        // GET: Mando
        public ActionResult Index()
        {
            IEnumerable<Mando> mandos = bd.Mandos;
            return View(mandos);
        }

        // GET: Mando/Details/5
        public ActionResult Details(int id)
        {
            Mando mando_buscado = bd.Mandos.Find(id);
            return View(mando_buscado);
        }

        // GET: Mando/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mando/Create
        [HttpPost]
        public ActionResult Create(Mando new_mando)
        {
            try
            {
                bd.Mandos.Add(new_mando);
                bd.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mando/Edit/5
        public ActionResult Edit(int id)
        {
            Mando mando_buscado = bd.Mandos.Find(id);

            return View(mando_buscado);
        }

        // POST: Mando/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Mando ma)
        {
            try
            {
                // TODO: Add update logic here
                Mando mando_buscado = bd.Mandos.Find(id);

                mando_buscado.marca = ma.marca;
                mando_buscado.modelo = ma.modelo;
                mando_buscado.compatibilidad = ma.compatibilidad;
                mando_buscado.precio = ma.precio;
                mando_buscado.stock = ma.stock;
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mando/Delete/5
        public ActionResult Delete(int id)
        {
            Mando mando_buscado = bd.Mandos.Find(id);
            return View(mando_buscado);
        }

        // POST: Mando/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Mando mando_buscado = bd.Mandos.Find(id);
                bd.Mandos.Remove(mando_buscado);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
