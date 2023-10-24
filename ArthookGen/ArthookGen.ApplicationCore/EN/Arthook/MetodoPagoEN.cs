
using System;
// Definición clase MetodoPagoEN
namespace ArthookGen.ApplicationCore.EN.Arthook
{
public partial class MetodoPagoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> pedido;



/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}





public MetodoPagoEN()
{
        pedido = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN>();
        usuario = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN>();
}



public MetodoPagoEN(int id, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> pedido, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> usuario
                    )
{
        this.init (Id, pedido, usuario);
}


public MetodoPagoEN(MetodoPagoEN metodoPago)
{
        this.init (metodoPago.Id, metodoPago.Pedido, metodoPago.Usuario);
}

private void init (int id
                   , System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> pedido, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> usuario)
{
        this.Id = id;


        this.Pedido = pedido;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MetodoPagoEN t = obj as MetodoPagoEN;
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
