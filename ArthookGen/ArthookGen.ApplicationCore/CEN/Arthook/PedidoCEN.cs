

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

public int New_ (Nullable<DateTime> p_fecha, ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum p_estado, int p_usuarioPedido)
{
        PedidoEN pedidoEN = null;
        int oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Fecha = p_fecha;

        pedidoEN.Estado = p_estado;


        if (p_usuarioPedido != -1) {
                // El argumento p_usuarioPedido -> Property usuarioPedido es oid = false
                // Lista de oids id
                pedidoEN.UsuarioPedido = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                pedidoEN.UsuarioPedido.Id = p_usuarioPedido;
        }



        oid = _IPedidoRepository.New_ (pedidoEN);
        return oid;
}

public void Modify (int p_Pedido_OID, Nullable<DateTime> p_fecha, ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum p_estado)
{
        PedidoEN pedidoEN = null;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Id = p_Pedido_OID;
        pedidoEN.Fecha = p_fecha;
        pedidoEN.Estado = p_estado;
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
public System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> FiltarPorEstado (ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum ? p_estado)
{
        return _IPedidoRepository.FiltarPorEstado (p_estado);
}
}
}
