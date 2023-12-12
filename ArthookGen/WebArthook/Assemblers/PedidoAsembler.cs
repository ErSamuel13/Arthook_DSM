using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebArthook.Models;
using ArthookGen.ApplicationCore.EN.Arthook;

namespace WebArthook.Assemblers
{
    public class PedidoAsembler
    {
        public PedidoViewModel convertirEnViewModel(PedidoEN pedEN) {
            PedidoViewModel pedVM = new PedidoViewModel();

            pedVM.id = pedEN.Id;
            pedVM.fecha = pedEN.Fecha;
            pedVM.pTotal = pedEN.PrecioTotal;
            pedVM.estado = pedEN.Estado;

            return pedVM;
        }

        public IList<PedidoViewModel> convertirListEnViewModel(IList<PedidoEN> pedEnList) {
            IList<PedidoViewModel> pedVMList = new List<PedidoViewModel>();

            foreach (PedidoEN pedEN in pedEnList){

                pedVMList.Add(convertirEnViewModel(pedEN));
            }

            return pedVMList;
        }
    }
}
