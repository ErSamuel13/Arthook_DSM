

using System;
using System.Text;
using System.Collections.Generic;

using ArthookGen.ApplicationCore.Exceptions;

using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;


namespace ArthookGen.ApplicationCore.CEN.Arthook
{
/*
 *      Definition of the class PublicacionCEN
 *
 */
public partial class PublicacionCEN
{
private IPublicacionRepository _IPublicacionRepository;

public PublicacionCEN(IPublicacionRepository _IPublicacionRepository)
{
        this._IPublicacionRepository = _IPublicacionRepository;
}

public IPublicacionRepository get_IPublicacionRepository ()
{
        return this._IPublicacionRepository;
}

public int New_ (ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum p_tipo, string p_descripcion, string p_titulo, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum p_tipoPublicacion, int p_usuarioPublicacion)
{
        PublicacionEN publicacionEN = null;
        int oid;

        //Initialized PublicacionEN
        publicacionEN = new PublicacionEN ();
        publicacionEN.Tipo = p_tipo;

        publicacionEN.Descripcion = p_descripcion;

        publicacionEN.Titulo = p_titulo;

        publicacionEN.TipoPublicacion = p_tipoPublicacion;


        if (p_usuarioPublicacion != -1) {
                // El argumento p_usuarioPublicacion -> Property usuarioPublicacion es oid = false
                // Lista de oids id
                publicacionEN.UsuarioPublicacion = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                publicacionEN.UsuarioPublicacion.Id = p_usuarioPublicacion;
        }



        oid = _IPublicacionRepository.New_ (publicacionEN);
        return oid;
}

public void Modify (int p_Publicacion_OID, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum p_tipo, string p_descripcion, string p_titulo, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum p_tipoPublicacion)
{
        PublicacionEN publicacionEN = null;

        //Initialized PublicacionEN
        publicacionEN = new PublicacionEN ();
        publicacionEN.Id = p_Publicacion_OID;
        publicacionEN.Tipo = p_tipo;
        publicacionEN.Descripcion = p_descripcion;
        publicacionEN.Titulo = p_titulo;
        publicacionEN.TipoPublicacion = p_tipoPublicacion;
        //Call to PublicacionRepository

        _IPublicacionRepository.Modify (publicacionEN);
}

public void Destroy (int id
                     )
{
        _IPublicacionRepository.Destroy (id);
}

public PublicacionEN ReadOID (int id
                              )
{
        PublicacionEN publicacionEN = null;

        publicacionEN = _IPublicacionRepository.ReadOID (id);
        return publicacionEN;
}

public System.Collections.Generic.IList<PublicacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PublicacionEN> list = null;

        list = _IPublicacionRepository.ReadAll (first, size);
        return list;
}
}
}
