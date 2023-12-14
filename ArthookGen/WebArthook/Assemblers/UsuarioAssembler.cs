using ArthookGen.ApplicationCore.EN.Arthook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebArthook.Models;

namespace WebArthook.Assemblers
{
    public class UsuarioAssembler
    {
        public UsuarioViewModel convertirEnToViewModel(UsuarioEN usuen)
        {
            UsuarioViewModel usu = new UsuarioViewModel();
            
            usu.id = usuen.Id;
            usu.nombre = usuen.Nombre;
            usu.email = usuen.Email;
            usu.nickname = usuen.Nickname;

            return usu;
        }

        public IList<UsuarioViewModel> ConvertirListEnToViewModel(IList<UsuarioEN>listusuen) {
            IList<UsuarioViewModel> usus = new List<UsuarioViewModel>();
            foreach(UsuarioEN usu in listusuen)
            {
                usus.Add(convertirEnToViewModel(usu));
            }
            return usus;
        }

    }
}
