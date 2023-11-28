using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arthook_web.Models;
using ArthookGen.ApplicationCore.EN.Arthook;

namespace Arthook_web.Assemblers
{
    public class ValoracionPublicacionAssembler
    {
        public ValoracionPublicacionViewModel ConvertirENToViewModel(ValoracionPublicacionEN en)
        {
            ValoracionPublicacionViewModel pub = new ValoracionPublicacionViewModel();
            pub.NumReferencia = en.Id;
            pub.Puntuacion = en.Puntuacion;
            pub.Comentario = en.Comentario;
            pub.Usuario = en.UsuarioValoracion;
            pub.Publicacion = en.PublicacionValoracion;

            return pub;
        }

        public IList<ValoracionPublicacionViewModel> ConvertirListENToViewModel(IList<ValoracionPublicacionEN> ens)
        {
            IList<ValoracionPublicacionViewModel> pubs = new List<ValoracionPublicacionViewModel>();
            foreach (ValoracionPublicacionEN en in ens)
            {
                pubs.Add(ConvertirENToViewModel(en));
            }
            return pubs;
        }
    }
}
