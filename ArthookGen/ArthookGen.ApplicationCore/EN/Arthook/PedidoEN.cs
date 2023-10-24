
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
private Nullable<DateTime> fecha;



/**
 *	Atributo precioTotal
 */
private float precioTotal;



/**
 *	Atributo estado
 */
private ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum estado;



/**
 *	Atributo attribute
 */
private string attribute;



/**
 *	Atributo linPed
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN> linPed;



/**
 *	Atributo usuario
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario;



/**
 *	Atributo devolucion
 */
private ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN devolucion;



/**
 *	Atributo metodoPago
 */
private ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN metodoPago;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual float PrecioTotal {
        get { return precioTotal; } set { precioTotal = value;  }
}



public virtual ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual string Attribute {
        get { return attribute; } set { attribute = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN> LinPed {
        get { return linPed; } set { linPed = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN Devolucion {
        get { return devolucion; } set { devolucion = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN MetodoPago {
        get { return metodoPago; } set { metodoPago = value;  }
}





public PedidoEN()
{
        linPed = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN>();
}



public PedidoEN(int id, Nullable<DateTime> fecha, float precioTotal, ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum estado, string attribute, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN> linPed, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario, ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN devolucion, ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN metodoPago
                )
{
        this.init (Id, fecha, precioTotal, estado, attribute, linPed, usuario, devolucion, metodoPago);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (pedido.Id, pedido.Fecha, pedido.PrecioTotal, pedido.Estado, pedido.Attribute, pedido.LinPed, pedido.Usuario, pedido.Devolucion, pedido.MetodoPago);
}

private void init (int id
                   , Nullable<DateTime> fecha, float precioTotal, ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum estado, string attribute, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN> linPed, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario, ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN devolucion, ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN metodoPago)
{
        this.Id = id;


        this.Fecha = fecha;

        this.PrecioTotal = precioTotal;

        this.Estado = estado;

        this.Attribute = attribute;

        this.LinPed = linPed;

        this.Usuario = usuario;

        this.Devolucion = devolucion;

        this.MetodoPago = metodoPago;
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
