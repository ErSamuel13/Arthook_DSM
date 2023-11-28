

using System;
using System.Text;
using System.Collections.Generic;

using ArthookGen.ApplicationCore.Exceptions;

using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;
using Newtonsoft.Json;


namespace ArthookGen.ApplicationCore.CEN.Arthook
{
/*
 *      Definition of the class TarifaCEN
 *
 */
public partial class TarifaCEN
{
private ITarifaRepository _ITarifaRepository;

public TarifaCEN(ITarifaRepository _ITarifaRepository)
{
        this._ITarifaRepository = _ITarifaRepository;
}

public ITarifaRepository get_ITarifaRepository ()
{
        return this._ITarifaRepository;
}

public int New_ (float p_precio, string p_descripcion, string p_nombre, int p_usuarioTarifa)
{
        TarifaEN tarifaEN = null;
        int oid;

        //Initialized TarifaEN
        tarifaEN = new TarifaEN ();
        tarifaEN.Precio = p_precio;

        tarifaEN.Descripcion = p_descripcion;

        tarifaEN.Nombre = p_nombre;


        if (p_usuarioTarifa != -1) {
                // El argumento p_usuarioTarifa -> Property usuarioTarifa es oid = false
                // Lista de oids id
                tarifaEN.UsuarioTarifa = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                tarifaEN.UsuarioTarifa.Id = p_usuarioTarifa;
        }



        oid = _ITarifaRepository.New_ (tarifaEN);
        return oid;
}

public void Modify (int p_Tarifa_OID, float p_precio, string p_descripcion, string p_nombre)
{
        TarifaEN tarifaEN = null;

        //Initialized TarifaEN
        tarifaEN = new TarifaEN ();
        tarifaEN.Id = p_Tarifa_OID;
        tarifaEN.Precio = p_precio;
        tarifaEN.Descripcion = p_descripcion;
        tarifaEN.Nombre = p_nombre;
        //Call to TarifaRepository

        _ITarifaRepository.Modify (tarifaEN);
}

public void Destroy (int id
                     )
{
        _ITarifaRepository.Destroy (id);
}

public TarifaEN ReadOID (int id
                         )
{
        TarifaEN tarifaEN = null;

        tarifaEN = _ITarifaRepository.ReadOID (id);
        return tarifaEN;
}

public System.Collections.Generic.IList<TarifaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TarifaEN> list = null;

        list = _ITarifaRepository.ReadAll (first, size);
        return list;
}
}
}
