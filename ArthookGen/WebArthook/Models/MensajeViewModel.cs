using ArthookGen.ApplicationCore.Enumerated.Arthook;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebArthook.Models
{
    public class MensajeViewModel
    {
        [ScaffoldColumn(false)]
        public int id { get; set; }

        public Nullable<DateTime> fecha { get; set; }

        [Display(Prompt = " escribe el mensaje a enviar", Description = "contenido del mensaje", Name = "contenido ")]
        [Required(ErrorMessage = "no puedes enviar un mensaje vacío")]
        [StringLength(maximumLength: 200, ErrorMessage = "el mensaje tiene que tener como mucho 200 caracteres")]
        public string contenido { get; set; }

        [ScaffoldColumn(false)]
        public int emisor { get; set; }

        [ScaffoldColumn(false)]
        public int receptor { get; set; }
    }
}
