using ArthookGen.ApplicationCore.Enumerated.Arthook;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebArthook.Models
{
    public class UsuarioViewModel
    {
        [ScaffoldColumn(false)]
        public int id { get; set; }

        [Display(Prompt =" escribe el nombre del usuario", Description = "nombre del usuario", Name ="nombre ")]
        [Required(ErrorMessage ="debe tener nombre")]
        [StringLength(maximumLength:50, ErrorMessage ="el nombre tiene que tener como mucho 50 caracteres")]
        public string nombre { get; set; }

        [Display(Prompt = " escribe el email del usuario", Description = "email del usuario", Name = "email ")]
        [Required(ErrorMessage = "debe tener email")]
        [StringLength(maximumLength: 50, ErrorMessage = "el email tiene que tener como mucho 50 caracteres")]
        public string email { get; set; }

        [Display(Prompt = " escribe el nickname del usuario", Description = "nickname del usuario", Name = "nickname ")]
        [Required(ErrorMessage = "debe tener email")]
        [StringLength(maximumLength: 50, ErrorMessage = "el nickname tiene que tener como mucho 50 caracteres")]
        public string nickname { get; set; }


        [Display(Prompt = " de que tipo es el usuario", Description = "Tipo  de usuario", Name = "TipoUsuario ")]
        [Required(ErrorMessage = "debe ser o usuario o artista")]
        public TipoUsuarioEnum TipoUsuario { get; set; }

        [Display(Prompt = " escribe el password del usuario", Description = "Password del usuario", Name = "Pasword")]
        [Required(ErrorMessage = " el usuario  debe tener password")]
        [DataType(DataType.Password,ErrorMessage ="el password debe ser correcto")]
        [StringLength(maximumLength: 16, ErrorMessage = "el Password tiene que tener como mucho 16 caracteres")]
        public string password { get; set; }


    }
}
