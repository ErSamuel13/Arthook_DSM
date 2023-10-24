

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

public int New_ (float p_Puntuacion, string p_Comentario, int p_publicacion, int p_usuario)
{
        ValoracionPublicacionEN valoracionPublicacionEN = null;
        int oid;

        //Initialized ValoracionPublicacionEN
        valoracionPublicacionEN = new ValoracionPublicacionEN ();
        valoracionPublicacionEN.Puntuacion = p_Puntuacion;

        valoracionPublicacionEN.Comentario = p_Comentario;


        if (p_publicacion != -1) {
                // El argumento p_publicacion -> Property publicacion es oid = false
                // Lista de oids id
                valoracionPublicacionEN.Publicacion = new ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN ();
                valoracionPublicacionEN.Publicacion.Id = p_publicacion;
        }


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                valoracionPublicacionEN.Usuario = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                valoracionPublicacionEN.Usuario.Id = p_usuario;
        }



        oid = _IValoracionPublicacionRepository.New_ (valoracionPublicacionEN);
        return oid;
}

public void Modify (int p_ValoracionPublicacion_OID, float p_Puntuacion, string p_Comentario)
{
        ValoracionPublicacionEN valoracionPublicacionEN = null;

        //Initialized ValoracionPublicacionEN
        valoracionPublicacionEN = new ValoracionPublicacionEN ();
        valoracionPublicacionEN.Id = p_ValoracionPublicacion_OID;
        valoracionPublicacionEN.Puntuacion = p_Puntuacion;
        valoracionPublicacionEN.Comentario = p_Comentario;
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
