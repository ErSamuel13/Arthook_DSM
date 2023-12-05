using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebArthook.Models
{
    public class LoginUsuarioViewModel
    {
        [Display(Prompt = " escribe el email del usuario", Description = "email del usuario", Name = "email ")]
        [Required(ErrorMessage = "el email es obligatorio")]

        public string email { get; set; }
        [Display(Prompt = " escribe el password del usuario", Description = "Password del usuario", Name = "Pasword")]
        [Required(ErrorMessage = "el password es obligatorio")]
        [DataType(DataType.Password)]
        
        public string password { get; set; }
    }
}
