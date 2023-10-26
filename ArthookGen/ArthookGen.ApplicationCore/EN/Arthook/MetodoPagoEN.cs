
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
 *	Atributo usuarioMetodoPago
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> usuarioMetodoPago;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> UsuarioMetodoPago {
        get { return usuarioMetodoPago; } set { usuarioMetodoPago = value;  }
}





public MetodoPagoEN()
{
        usuarioMetodoPago = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN>();
}



public MetodoPagoEN(int id, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> usuarioMetodoPago
                    )
{
        this.init (Id, usuarioMetodoPago);
}


public MetodoPagoEN(MetodoPagoEN metodoPago)
{
        this.init (metodoPago.Id, metodoPago.UsuarioMetodoPago);
}

private void init (int id
                   , System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> usuarioMetodoPago)
{
        this.Id = id;


        this.UsuarioMetodoPago = usuarioMetodoPago;
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
