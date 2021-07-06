using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiVideojuegos.Models.ViewModel
{
    public class JuegoViewModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string plataforma { get; set; }
        public int anio { get; set; }
        public int precio { get; set; }
        public int stock { get; set; }

        public int restriccion { get; set; }

    }
}