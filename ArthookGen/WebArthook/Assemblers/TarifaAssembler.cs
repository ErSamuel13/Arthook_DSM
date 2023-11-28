using ArthookGen.ApplicationCore.EN.Arthook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebArthook.Models;

namespace WebArthook.Assemblers
{
    public class TarifaAssembler
    {
        public TarifaViewModel convertirEnToViewModel(TarifaEN taren)
        {
            TarifaViewModel tar = new TarifaViewModel();
            tar.id = taren.Id;
            tar.precio = taren.Precio;
            tar.descripcion = taren.Descripcion;
            tar.nombre = taren.Nombre;
            return tar;
        }

        public IList<TarifaViewModel> ConvertirListEnToViewModel(IList<TarifaEN> listtaren)
        {
            IList<TarifaViewModel> tars = new List<TarifaViewModel>();
            foreach (TarifaEN tar in listtaren)
            {
                tars.Add(convertirEnToViewModel(tar));
            }
            return tars;
        }

    }
}
