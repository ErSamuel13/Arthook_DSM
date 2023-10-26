
using System;
// Definición clase PedidoEN
namespace ArthookGen.ApplicationCore.EN.Arthook
{
public partial class PedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo fecha
 */
private string fecha;



/**
 *	Atributo precioTotal
 */
private string precioTotal;



/**
 *	Atributo estado
 */
private ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum estado;



/**
 *	Atributo linPedPed
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN> linPedPed;



/**
 *	Atributo usuarioPedido
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioPedido;



/**
 *	Atributo devolucionPedido
 */
private ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN devolucionPedido;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual string PrecioTotal {
        get { return precioTotal; } set { precioTotal = value;  }
}



public virtual ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN> LinPedPed {
        get { return linPedPed; } set { linPedPed = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN UsuarioPedido {
        get { return usuarioPedido; } set { usuarioPedido = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN DevolucionPedido {
        get { return devolucionPedido; } set { devolucionPedido = value;  }
}





public PedidoEN()
{
        linPedPed = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN>();
}



public PedidoEN(int id, string fecha, string precioTotal, ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum estado, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN> linPedPed, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioPedido, ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN devolucionPedido
                )
{
        this.init (Id, fecha, precioTotal, estado, linPedPed, usuarioPedido, devolucionPedido);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (pedido.Id, pedido.Fecha, pedido.PrecioTotal, pedido.Estado, pedido.LinPedPed, pedido.UsuarioPedido, pedido.DevolucionPedido);
}

private void init (int id
                   , string fecha, string precioTotal, ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum estado, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN> linPedPed, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioPedido, ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN devolucionPedido)
{
        this.Id = id;


        this.Fecha = fecha;

        this.PrecioTotal = precioTotal;

        this.Estado = estado;

        this.LinPedPed = linPedPed;

        this.UsuarioPedido = usuarioPedido;

        this.DevolucionPedido = devolucionPedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoEN t = obj as PedidoEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
