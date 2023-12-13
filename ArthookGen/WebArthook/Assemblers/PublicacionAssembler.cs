using ArthookGen.ApplicationCore.EN.Arthook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebArthook.Models;

namespace WebArthook.Assemblers
{
    public class PublicacionAssembler
    {
        public PublicacionViewModel ConvertirENToViewModel(PublicacionEN en)
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
            pub.Imagen = en.Imagen;

            return pub;
        }

        public IList<PublicacionViewModel> ConvertirListENToViewModel(IList<PublicacionEN> ens)
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
