using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiVideojuegos.Models.ViewModel
{
    public class ConsolaViewModel
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int anio { get; set; }
        public int nueva { get; set; }

        public int precio { get; set; }
        public int stock { get; set; }

    }
}