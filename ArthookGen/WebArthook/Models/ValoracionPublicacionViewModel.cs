using ArthookGen.ApplicationCore.Enumerated.Arthook;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebArthook.Models
{
    public class ValoracionPublicacionViewModel
    {
        [ScaffoldColumn(false)]
        public int NumReferencia { get; set; }

        [Display(Prompt = "Introduce la puntuacion de la publicacion.", Description = "Puntuacion de la publicacion", Name = "Puntuacion")]
        [Required(ErrorMessage = "Debe indicar la puntuacion de una publicacion")]
        [Range(minimum: 0, maximum: 5, ErrorMessage = "La puntuación debe de ser entre 0 y 5")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Por favor introduce un número entero")]
        public float Puntuacion { get; set; }

        [Display(Prompt = "Comenta la valoración", Description = "Comentario de la valoración", Name = "Comentario")]
        [Required(ErrorMessage = "Debe indicar un comentario para la valoración de la publicacion")]
        [StringLength(maximumLength: 10000, ErrorMessage = "No puede tener más de 10000 carácteres.")]
        public string Comentario { get; set; }


        [Display(Prompt = "Introduce el usuario que ha valorado", Description = "Usuario de la valoración", Name = "Usuario")]
        [Required(ErrorMessage = "Debe indicar el usuario")]
        //Falta algo más
        public ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN Usuario { get; set; }

        [Display(Prompt = "Introduce la publicación a valorar", Description = "Publicación valorada", Name = "Publicacion")]
        [Required(ErrorMessage = "Debe indicar la publicación a valorar")]
        //Falta algo más
        public ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN Publicacion { get; set; }
    }
}
