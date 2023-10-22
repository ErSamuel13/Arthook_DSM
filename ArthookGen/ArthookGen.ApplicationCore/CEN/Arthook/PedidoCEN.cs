

using System;
using System.Text;
using System.Collections.Generic;

using ArthookGen.ApplicationCore.Exceptions;

using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;


namespace ArthookGen.ApplicationCore.CEN.Arthook
{
/*
 *      Definition of the class PedidoCEN
 *
 */
public partial class PedidoCEN
{
private IPedidoRepository _IPedidoRepository;

public PedidoCEN(IPedidoRepository _IPedidoRepository)
{
        this._IPedidoRepository = _IPedidoRepository;
}

public IPedidoRepository get_IPedidoRepository ()
{
        return this._IPedidoRepository;
}

public int New_ (Nullable<DateTime> p_fecha, float p_precioTotal, ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum p_estado, string p_attribute, int p_usuario)
{
        PedidoEN pedidoEN = null;
        int oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Fecha = p_fecha;

        pedidoEN.PrecioTotal = p_precioTotal;

        pedidoEN.Estado = p_estado;

        pedidoEN.Attribute = p_attribute;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                pedidoEN.Usuario = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                pedidoEN.Usuario.Id = p_usuario;
        }



        oid = _IPedidoRepository.New_ (pedidoEN);
        return oid;
}

public void Modify (int p_Pedido_OID, Nullable<DateTime> p_fecha, float p_precioTotal, ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum p_estado, string p_attribute)
{
        PedidoEN pedidoEN = null;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Id = p_Pedido_OID;
        pedidoEN.Fecha = p_fecha;
        pedidoEN.PrecioTotal = p_precioTotal;
        pedidoEN.Estado = p_estado;
        pedidoEN.Attribute = p_attribute;
        //Call to PedidoRepository

        _IPedidoRepository.Modify (pedidoEN);
}

public void Destroy (int id
                     )
{
        _IPedidoRepository.Destroy (id);
}

public PedidoEN ReadOID (int id
                         )
{
        PedidoEN pedidoEN = null;

        pedidoEN = _IPedidoRepository.ReadOID (id);
        return pedidoEN;
}

public System.Collections.Generic.IList<PedidoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> list = null;

        list = _IPedidoRepository.ReadAll (first, size);
        return list;
}
}
}
