using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiVideojuegos.Models;
using ApiVideojuegos.Models.ViewModel;

namespace ApiVideojuegos.Controllers
{
    public class JuegosController : ApiController
    {
        videojuegosEntities1 bd = new videojuegosEntities1();
        public IEnumerable<JuegoViewModel> Get()
        {

            IEnumerable<JuegoViewModel> juegos = (from Juego in bd.Juegos
                                                  select new JuegoViewModel()
                                                  {
                                                      id = Juego.id,
                                                      nombre = Juego.nombre,
                                                      plataforma = Juego.plataforma,
                                                      anio = Juego.anio,
                                                      precio = Juego.precio,
                                                      stock = Juego.stock,
                                                      restriccion = Juego.restriccion
                                                  }).ToList();
            return juegos;
        }
        public Juego Get(int id)
        {
            Juego j = bd.Juegos.Find(id);

            return j;
        }
    }
}

