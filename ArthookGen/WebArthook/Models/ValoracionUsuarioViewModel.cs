using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebArthook.Models
{
    public class ValoracionUsuarioViewModel
    {
        [ScaffoldColumn(false)]
        public int id { get; set; }
        public float puntuacion { get; set; }

        public int emisor { get; set; }
        public int receptor { get; set; }
        public string n_emisor { get; set; }

        public string n_receptor { get; set; }

    }
}
