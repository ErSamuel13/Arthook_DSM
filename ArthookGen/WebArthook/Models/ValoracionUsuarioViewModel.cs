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

        [ScaffoldColumn(false)]
        public int emisor { get; set; }

        [ScaffoldColumn(false)]
        public int receptor { get; set; }

        [Display(Prompt ="nombre del Emisor", Description ="Nombre de quien puntua",Name ="nombreEmisor")]
        public string n_emisor { get; set; }

        [Display(Prompt = "nombre del Receptor", Description = "Nombre de quien es putuado", Name = "nombreReceptor")]
        public string n_receptor { get; set; }

    }
}
