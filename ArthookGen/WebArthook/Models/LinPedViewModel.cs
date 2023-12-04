using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebArthook.Models
{
    public class LinPedViewModel
    {
        [ScaffoldColumn(false)]
        public int id { set; get; }

        /*CANTIDAD*/
        [Display(Prompt = "Cantidad de producto", Description = "Cantidad de producto", Name = "cantidad")]
        [Required(ErrorMessage = "La línea de pedido requiere una cantidad")]
        public int cantidad { set; get; }

        /*PRECIO_TOTAL*/
        [Display(Prompt = "Precio total de la línea", Description = "Precio total de la línea", Name = "precioT")]
        [Required(ErrorMessage = "La línea de pedido requiere una cantidad")]
        public float precioT { set; get; }

        /*El resto de atributos reciben un objeto :D*/
    }
}
