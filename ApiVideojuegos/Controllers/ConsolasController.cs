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
    public class ConsolasController : ApiController
    {
        videojuegosEntities1 bd = new videojuegosEntities1();
        public IEnumerable<ConsolaViewModel> Get()
        {

            IEnumerable<ConsolaViewModel> consolas = (from Consola in bd.Consolas
                                                    select new ConsolaViewModel()
                                                  {
                                                      id = Consola.id,
                                                      marca = Consola.marca,
                                                      modelo = Consola.modelo,
                                                      anio = Consola.anio,
                                                      nueva = Consola.nueva,
                                                      precio = Consola.precio,
                                                      stock = Consola.stock
                                                      
                                                  }).ToList();
            return consolas;
        }
        public Consola Get(int id)
        {
            Consola c = bd.Consolas.Find(id);

            return c;
        }
    }
}
