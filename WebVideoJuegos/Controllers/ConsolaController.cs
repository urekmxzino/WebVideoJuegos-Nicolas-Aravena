using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVideoJuegos.Models;

namespace WebVideoJuegos.Controllers
{
    public class ConsolaController : Controller
    {
        ModeloBD bd = new ModeloBD();
        // GET: Consola
        public ActionResult Index()
        {
            IEnumerable<Consola> consolas = bd.Consolas;
            return View(consolas);
        }

        // GET: Consola/Details/5
        public ActionResult Details(int id)
        {
            Consola consola_buscada = bd.Consolas.Find(id);
            return View(consola_buscada);
        }

        // GET: Consola/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consola/Create
        [HttpPost]
        public ActionResult Create(Consola new_consola)
        {
            try
            {
                bd.Consolas.Add(new_consola);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consola/Edit/5
        public ActionResult Edit(int id)
        {
            Consola consola_buscada = bd.Consolas.Find(id);
            return View(consola_buscada);
        }

        // POST: Consola/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Consola co)
        {
            try
            {
                Consola consola_buscada = bd.Consolas.Find(id);


                consola_buscada.marca = co.marca;
                consola_buscada.modelo = co.modelo;
                consola_buscada.anio = co.anio;
                consola_buscada.nueva = co.nueva;
                consola_buscada.precio = co.precio;
                consola_buscada.stock = co.stock;
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consola/Delete/5
        public ActionResult Delete(int id)
        {
            Consola consola_buscada = bd.Consolas.Find(id);
            return View(consola_buscada);
        }

        // POST: Consola/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Consola consola_buscada = bd.Consolas.Find(id);
                bd.Consolas.Remove(consola_buscada);
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
