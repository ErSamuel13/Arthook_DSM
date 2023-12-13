using ArthookGen.ApplicationCore.Enumerated.Arthook;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebArthook.Models
{
    public class PublicacionViewModel
    {
        [ScaffoldColumn(false)]
        public int NumReferencia { get; set; }

        [Display(Prompt = "Titula la publicacion", Description = "Título de la publicacion", Name = "Título")]
        [Required(ErrorMessage = "Debe indicar un nombre para la publicacion")]
        [StringLength(maximumLength: 40, ErrorMessage = "El título no puede tener más de 40 carácteres.")]
        public string Titulo { get; set; }

        [Display(Prompt = "Describe la publicacion", Description = "Descripción de la publicacion", Name = "Descripción")]
        [Required(ErrorMessage = "Debe indicar un nombre para la publicacion")]
        [StringLength(maximumLength:200, ErrorMessage = "La descripción no puede tener más de 200 carácteres.")]
        public string Descripcion { get; set; }

        [Display(Prompt = "Introduce el precio de la publicacion.", Description = "Precio de la publicacion", Name = "Precio")]
        [Required(ErrorMessage = "Debe indicar el precio de una publicacion")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El precio debe de ser mayor que 0 y menor que 10000")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Por favor introduce un número entero para el stock")]
        public float Precio { get; set; }

        [Display(Prompt = "Introduce el tipo de la publicación", Description = "Tipo de la publicación", Name = "Tipo Publicacion")]
        [Required(ErrorMessage = "Debe indicar el tipo de una publicación")]
        //Falta algo más
        public ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum TipoPublicacion { get; set; }

        [Display(Prompt = "Introduce el tipo de producto de la publicación", Description = "Tipo de producto de la publicación", Name = "Tipo Producto")]
        [Required(ErrorMessage = "Debe indicar el tipo de producto de una publicación")]
        //Falta algo más
        public ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum TipoProducto { get; set; }

        [Display(Prompt = "Introduce el usuario que ha creado la publicación", Description = "Usuario creador de la publicación", Name = "Usuario")]
        [Required(ErrorMessage = "Debe indicar el usuario creador de una publicación")]
        //Falta algo más
        public ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN Usuario { get; set; }

        [Display(Prompt = "Introduce la valoración de la publicación", Description = "Valoración de la publicación", Name = "Valoración")]
        [Required(ErrorMessage = "Debe indicar la valoración de la publicación")]
        //Falta algo más
        public System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> Valoracion { get; set; }

        [ScaffoldColumn(false)]

        [Display(Prompt = "Introduce la línea de pedido de la publicación", Description = "Línea de pedido de de la publicación", Name = "Línea Pedido")]
        [Required(ErrorMessage = "Debe indicar la línea de pedido de una publicación")]
        //Falta algo más
        public System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN> LinPed { get; set; }
    [ScaffoldColumn(false)]
        public string Imagen { get; set; }
        [Display(Prompt ="archivo", Description ="archivo de la publicacion",Name ="archivo")]
        public IFormFile Fichero { get; set; }
    
    }

}
