using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arthook_web.Models;
using ArthookGen.ApplicationCore.EN.Arthook;

namespace Arthook_web.Assemblers
{
    public class PublicacionAssembler
    {
        public PublicacionViewModel ConvertirENToViewModel (PublicacionEN en)
        {
            PublicacionViewModel pub = new PublicacionViewModel();
            pub.NumReferencia = en.Id;
            pub.Titulo = en.Titulo;
            pub.Descripcion = en.Descripcion;
            pub.Precio = en.Pvp;
            pub.TipoPublicacion = en.TipoPublicacion;
            pub.TipoProducto = en.Tipo;
            pub.Valoracion = en.ValoracionPublicacion;
            pub.LinPed = en.LinPedPublicacion;
            pub.Usuario = en.UsuarioPublicacion;

            return pub;
        }

        public IList<PublicacionViewModel> ConvertirListENToViewModel (IList<PublicacionEN> ens)
        {
            IList<PublicacionViewModel> pubs = new List<PublicacionViewModel>();
            foreach (PublicacionEN en in ens)
            {
                pubs.Add(ConvertirENToViewModel(en));
            }
            return pubs;
        }
    }
}
