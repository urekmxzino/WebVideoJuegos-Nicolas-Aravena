using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVideoJuegos.Models;
namespace WebVideoJuegos.Controllers
{
    public class JuegoController : Controller
    {
        ModeloBD bd = new ModeloBD();
        // GET: Juego
        public ActionResult Index()
        {
            IEnumerable<Juego> juegos = bd.Juegos;
            return View(juegos);
        }

        // GET: Juego/Details/5
        public ActionResult Details(int id)
        {
            Juego juego_buscado = bd.Juegos.Find(id);
            return View(juego_buscado);
        }

        // GET: Juego/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juego/Create
        [HttpPost]
        public ActionResult Create(Juego new_juego)
        {
            try
            {
                bd.Juegos.Add(new_juego);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juego/Edit/5
        public ActionResult Edit(int id)
        {
            Juego juego_buscado = bd.Juegos.Find(id);
            return View(juego_buscado);
        }

        // POST: Juego/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Juego ju)
        {
            try
            {
                Juego juego_buscado = bd.Juegos.Find(id);

                juego_buscado.nombre = ju.nombre;
                juego_buscado.plataforma = ju.plataforma;
                juego_buscado.anio = ju.anio;
                juego_buscado.precio = ju.precio;
                juego_buscado.stock = ju.stock;
                juego_buscado.restriccion = ju.restriccion;
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juego/Delete/5
        public ActionResult Delete(int id)
        {
            Juego juego_buscado = bd.Juegos.Find(id);
            return View(juego_buscado);
        }

        // POST: Juego/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Juego juego_buscado = bd.Juegos.Find(id);
                bd.Juegos.Remove(juego_buscado);
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
