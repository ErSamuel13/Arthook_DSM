

using System;
using System.Text;
using System.Collections.Generic;

using ArthookGen.ApplicationCore.Exceptions;

using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;


namespace ArthookGen.ApplicationCore.CEN.Arthook
{
/*
 *      Definition of the class DevolucionCEN
 *
 */
public partial class DevolucionCEN
{
private IDevolucionRepository _IDevolucionRepository;

public DevolucionCEN(IDevolucionRepository _IDevolucionRepository)
{
        this._IDevolucionRepository = _IDevolucionRepository;
}

public IDevolucionRepository get_IDevolucionRepository ()
{
        return this._IDevolucionRepository;
}

public int New_ (string p_descripcion, ArthookGen.ApplicationCore.Enumerated.Arthook.MotivoEnum p_motivo, Nullable<DateTime> p_fecha, int p_usuario, int p_pedido)
{
        DevolucionEN devolucionEN = null;
        int oid;

        //Initialized DevolucionEN
        devolucionEN = new DevolucionEN ();
        devolucionEN.Descripcion = p_descripcion;

        devolucionEN.Motivo = p_motivo;

        devolucionEN.Fecha = p_fecha;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                devolucionEN.Usuario = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                devolucionEN.Usuario.Id = p_usuario;
        }


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                devolucionEN.Pedido = new ArthookGen.ApplicationCore.EN.Arthook.PedidoEN ();
                devolucionEN.Pedido.Id = p_pedido;
        }



        oid = _IDevolucionRepository.New_ (devolucionEN);
        return oid;
}

public void Modify (int p_Devolucion_OID, string p_descripcion, ArthookGen.ApplicationCore.Enumerated.Arthook.MotivoEnum p_motivo, Nullable<DateTime> p_fecha)
{
        DevolucionEN devolucionEN = null;

        //Initialized DevolucionEN
        devolucionEN = new DevolucionEN ();
        devolucionEN.Id = p_Devolucion_OID;
        devolucionEN.Descripcion = p_descripcion;
        devolucionEN.Motivo = p_motivo;
        devolucionEN.Fecha = p_fecha;
        //Call to DevolucionRepository

        _IDevolucionRepository.Modify (devolucionEN);
}

public void Destroy (int id
                     )
{
        _IDevolucionRepository.Destroy (id);
}

public DevolucionEN ReadOID (int id
                             )
{
        DevolucionEN devolucionEN = null;

        devolucionEN = _IDevolucionRepository.ReadOID (id);
        return devolucionEN;
}

public System.Collections.Generic.IList<DevolucionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DevolucionEN> list = null;

        list = _IDevolucionRepository.ReadAll (first, size);
        return list;
}
}
}
