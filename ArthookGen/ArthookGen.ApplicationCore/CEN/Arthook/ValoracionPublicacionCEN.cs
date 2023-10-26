

using System;
using System.Text;
using System.Collections.Generic;

using ArthookGen.ApplicationCore.Exceptions;

using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;


namespace ArthookGen.ApplicationCore.CEN.Arthook
{
/*
 *      Definition of the class ValoracionPublicacionCEN
 *
 */
public partial class ValoracionPublicacionCEN
{
private IValoracionPublicacionRepository _IValoracionPublicacionRepository;

public ValoracionPublicacionCEN(IValoracionPublicacionRepository _IValoracionPublicacionRepository)
{
        this._IValoracionPublicacionRepository = _IValoracionPublicacionRepository;
}

public IValoracionPublicacionRepository get_IValoracionPublicacionRepository ()
{
        return this._IValoracionPublicacionRepository;
}

public int New_ (string p_puntuacion, string p_comentario, int p_usuarioValoracion, int p_publicacionValoracion)
{
        ValoracionPublicacionEN valoracionPublicacionEN = null;
        int oid;

        //Initialized ValoracionPublicacionEN
        valoracionPublicacionEN = new ValoracionPublicacionEN ();
        valoracionPublicacionEN.Puntuacion = p_puntuacion;

        valoracionPublicacionEN.Comentario = p_comentario;


        if (p_usuarioValoracion != -1) {
                // El argumento p_usuarioValoracion -> Property usuarioValoracion es oid = false
                // Lista de oids id
                valoracionPublicacionEN.UsuarioValoracion = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                valoracionPublicacionEN.UsuarioValoracion.Id = p_usuarioValoracion;
        }


        if (p_publicacionValoracion != -1) {
                // El argumento p_publicacionValoracion -> Property publicacionValoracion es oid = false
                // Lista de oids id
                valoracionPublicacionEN.PublicacionValoracion = new ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN ();
                valoracionPublicacionEN.PublicacionValoracion.Id = p_publicacionValoracion;
        }



        oid = _IValoracionPublicacionRepository.New_ (valoracionPublicacionEN);
        return oid;
}

public void Modify (int p_ValoracionPublicacion_OID, string p_puntuacion, string p_comentario)
{
        ValoracionPublicacionEN valoracionPublicacionEN = null;

        //Initialized ValoracionPublicacionEN
        valoracionPublicacionEN = new ValoracionPublicacionEN ();
        valoracionPublicacionEN.Id = p_ValoracionPublicacion_OID;
        valoracionPublicacionEN.Puntuacion = p_puntuacion;
        valoracionPublicacionEN.Comentario = p_comentario;
        //Call to ValoracionPublicacionRepository

        _IValoracionPublicacionRepository.Modify (valoracionPublicacionEN);
}

public void Destroy (int id
                     )
{
        _IValoracionPublicacionRepository.Destroy (id);
}

public ValoracionPublicacionEN ReadOID (int id
                                        )
{
        ValoracionPublicacionEN valoracionPublicacionEN = null;

        valoracionPublicacionEN = _IValoracionPublicacionRepository.ReadOID (id);
        return valoracionPublicacionEN;
}

public System.Collections.Generic.IList<ValoracionPublicacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ValoracionPublicacionEN> list = null;

        list = _IValoracionPublicacionRepository.ReadAll (first, size);
        return list;
}
}
}
