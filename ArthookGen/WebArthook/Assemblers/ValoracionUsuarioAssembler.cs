using ArthookGen.ApplicationCore.EN.Arthook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebArthook.Models;

namespace WebArthook.Assemblers
{
    public class ValoracionUsuarioAssembler
    {
        public ValoracionUsuarioViewModel convertirEnToViewModel(ValoracionUsuarioEN valen)
        {
            ValoracionUsuarioViewModel val = new ValoracionUsuarioViewModel();
            val.id = valen.Id;
            val.puntuacion = valen.Puntuacion;
            val.emisor = valen.EmVal.Id;
            val.receptor = valen.ReVal.Id;
            val.n_emisor = valen.EmVal.Nombre;
            val.n_receptor = valen.ReVal.Nombre;

           
            return val;
        }

        public IList<ValoracionUsuarioViewModel> ConvertirListEnToViewModel(IList<ValoracionUsuarioEN> listvalen)
        {
            IList<ValoracionUsuarioViewModel> vals = new List<ValoracionUsuarioViewModel>();
            foreach (ValoracionUsuarioEN val in listvalen)
            {
                vals.Add(convertirEnToViewModel(val));
            }
            return vals;
        }
    }
}
