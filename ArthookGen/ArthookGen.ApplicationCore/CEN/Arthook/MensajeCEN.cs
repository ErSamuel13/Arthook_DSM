

using System;
using System.Text;
using System.Collections.Generic;

using ArthookGen.ApplicationCore.Exceptions;

using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;


namespace ArthookGen.ApplicationCore.CEN.Arthook
{
/*
 *      Definition of the class MensajeCEN
 *
 */
public partial class MensajeCEN
{
private IMensajeRepository _IMensajeRepository;

public MensajeCEN(IMensajeRepository _IMensajeRepository)
{
        this._IMensajeRepository = _IMensajeRepository;
}

public IMensajeRepository get_IMensajeRepository ()
{
        return this._IMensajeRepository;
}

public int New_ (Nullable<DateTime> p_fecha, string p_contenido, int p_emisor, int p_receptor)
{
        MensajeEN mensajeEN = null;
        int oid;

        //Initialized MensajeEN
        mensajeEN = new MensajeEN ();
        mensajeEN.Fecha = p_fecha;

        mensajeEN.Contenido = p_contenido;


        if (p_emisor != -1) {
                // El argumento p_emisor -> Property emisor es oid = false
                // Lista de oids id
                mensajeEN.Emisor = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                mensajeEN.Emisor.Id = p_emisor;
        }


        if (p_receptor != -1) {
                // El argumento p_receptor -> Property receptor es oid = false
                // Lista de oids id
                mensajeEN.Receptor = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                mensajeEN.Receptor.Id = p_receptor;
        }



        oid = _IMensajeRepository.New_ (mensajeEN);
        return oid;
}

public void Modify (int p_Mensaje_OID, Nullable<DateTime> p_fecha, string p_contenido)
{
        MensajeEN mensajeEN = null;

        //Initialized MensajeEN
        mensajeEN = new MensajeEN ();
        mensajeEN.Id = p_Mensaje_OID;
        mensajeEN.Fecha = p_fecha;
        mensajeEN.Contenido = p_contenido;
        //Call to MensajeRepository

        _IMensajeRepository.Modify (mensajeEN);
}

public void Destroy (int id
                     )
{
        _IMensajeRepository.Destroy (id);
}

public MensajeEN ReadOID (int id
                          )
{
        MensajeEN mensajeEN = null;

        mensajeEN = _IMensajeRepository.ReadOID (id);
        return mensajeEN;
}

public System.Collections.Generic.IList<MensajeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MensajeEN> list = null;

        list = _IMensajeRepository.ReadAll (first, size);
        return list;
}
}
}
