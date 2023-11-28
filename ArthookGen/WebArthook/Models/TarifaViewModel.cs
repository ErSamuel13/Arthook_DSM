using ArthookGen.ApplicationCore.Enumerated.Arthook;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebArthook.Models
{
    public class TarifaViewModel
    {
        [ScaffoldColumn(false)]
        public int id { get; set; }

        [Display(Prompt = " escribe el nombre de la tarifa", Description = "nombre de la tarifa", Name = "nombre ")]
        [Required(ErrorMessage = "debe tener nombre")]
        [StringLength(maximumLength: 50, ErrorMessage = "el nombre tiene que tener como mucho 50 caracteres")]
        public string nombre { get; set; }

        [Display(Prompt = " Introduce un precio para la tarifa", Description = "precio de la tarifa", Name = "precio ")]
        [Required(ErrorMessage = "debe tener un precio")]
        public float precio { get; set; }

        [Display(Prompt = " escribe una breve desripción", Description = "descripción de la tarifa", Name = "descripción ")]
        [Required(ErrorMessage = "debe tener una descripción")]
        [StringLength(maximumLength: 200, ErrorMessage = "la descripción tiene que tener como mucho 200 caracteres")]
        public string descripcion { get; set; }

        [ScaffoldColumn(false)]
        public int usuario { get; set; }
    }
}