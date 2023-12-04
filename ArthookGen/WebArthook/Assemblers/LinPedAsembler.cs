using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebArthook.Models;
using ArthookGen.ApplicationCore.EN.Arthook;

namespace WebArthook.Assemblers
{
    public class LinPedAsembler
    {
        public LinPedViewModel convertirEnViewModel(LinPedEN LinPedEN)
        {
            LinPedViewModel LinPedVM = new LinPedViewModel();

            LinPedVM.id = LinPedEN.Id;
            LinPedVM.cantidad = LinPedEN.Cantidad;
            LinPedVM.precioT = LinPedEN.PrecioT;

            return LinPedVM;
        }

        public IList<LinPedViewModel> convertirListEnViewModel(IList<LinPedEN> LinPedEnList)
        {
            IList<LinPedViewModel> LinPedVMList = new List<LinPedViewModel>();

            foreach (LinPedEN linpedEN in LinPedEnList)
            {

                LinPedVMList.Add(convertirEnViewModel(linpedEN));
            }

            return LinPedVMList;
        }
    }
}
