using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.Enumerated.Arthook;

namespace WebArthook.Models
{
    public class PedidoViewModel
    {
        [ScaffoldColumn(false)]
        public int id { set; get; }

        /*FECHA*/
        [Display(Prompt = "Fecha del pedido", Description = "Fecha del pedido", Name = "fechaPedido")]
        [Required(ErrorMessage = "El pedido debe incluir una fecha y una hora")]
        public Nullable<DateTime> fecha { set; get; }


        /*PRECIO TOTAL*/
        [Display(Prompt = "Precio total", Description = "Precio Total del pedido", Name = "precioTotal")]
        [Required(ErrorMessage = "El pedido debe incluir un precio total")]
        [DataType(DataType.Currency, ErrorMessage = "El campo debe tener un valor numérico")]
        [Range(minimum: 0, maximum: 100000, ErrorMessage = "El precio no puede ser negativo")] //Consultar máximo
        public float pTotal { set; get; }


        /*ESTADO*/
        [Display(Prompt = "Estado del pedido", Description = "Estado del pedido", Name = "estado")]
        [Required(ErrorMessage = "El estado debe ser: enCarrito, pendiente, enviado, cancelado, devuelto")]
        public EstadoEnum estado { set; get; }


        /*Los que están a partir de aquín reciben objetos, por lo que necesitan un viewModel parcial o uno propio*/
        /*LINPED-PED Hacer un view model aparte*/
        /*[Display(Prompt = "lineas de pedido", Description = "lineas de pedido", Name = "linPedPed")]
        [Required(ErrorMessage = "El pedido debe incluir al menos un pedido")]
        public IList<LinPedEN> linpedPed { set; get; }*/

        /*USUARIO-PEDIDO*/


        /*DEVOLUCIÓN-PEDIDO*/
    }
}
