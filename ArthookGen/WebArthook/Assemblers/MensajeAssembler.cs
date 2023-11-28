using ArthookGen.ApplicationCore.EN.Arthook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebArthook.Models;

namespace WebArthook.Assemblers
{
    public class MensajeAssembler
    {
        public MensajeViewModel convertirEnToViewModel(MensajeEN mensajeen)
        {
            MensajeViewModel mensaje = new MensajeViewModel();
            mensaje.id = mensajeen.Id;
            mensaje.fecha = mensajeen.Fecha;
            mensaje.contenido = mensajeen.Contenido;
            mensaje.emisor = mensajeen.Emisor;
            mensaje.receptor = mensajeen.Receptor;
            return mensaje;
        }

        public IList<MensajeViewModel> ConvertirListEnToViewModel(IList<MensajeEN> listmensajeen)
        {
            IList<MensajeViewModel> mensajes = new List<MensajeViewModel>();
            foreach (MensajeEN men in listmensajeen)
            {
                mensajes.Add(convertirEnToViewModel(men));
            }
            return mensajes;
        }

    }
}
