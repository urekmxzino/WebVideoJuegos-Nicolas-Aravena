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
    public class MandosController : ApiController
    {
        videojuegosEntities1 bd = new videojuegosEntities1();
        public IEnumerable<MandoViewModel> Get()
        {
            
            IEnumerable<MandoViewModel> mandos = (from Mando in bd.Mandos
                                                select new MandoViewModel()
                                                {
                                                    id = Mando.id,
                                                    marca = Mando.marca,
                                                    modelo = Mando.modelo,
                                                    compatibilidad = Mando.compatibilidad,
                                                    precio = Mando.precio,
                                                    stock = Mando.stock
                                                }).ToList();
            return mandos;
        }
        public Mando Get(int id)
        {
            Mando m = bd.Mandos.Find(id);

            return m;
        }
    }
}
