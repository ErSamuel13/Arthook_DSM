
using System;
// Definición clase LinPedEN
namespace ArthookGen.ApplicationCore.EN.Arthook
{
public partial class LinPedEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo cantidad
 */
private string cantidad;



/**
 *	Atributo precio
 */
private string precio;



/**
 *	Atributo pedidoLinPed
 */
private ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedidoLinPed;



/**
 *	Atributo publicacionLinPed
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> publicacionLinPed;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual string Precio {
        get { return precio; } set { precio = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.PedidoEN PedidoLinPed {
        get { return pedidoLinPed; } set { pedidoLinPed = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> PublicacionLinPed {
        get { return publicacionLinPed; } set { publicacionLinPed = value;  }
}





public LinPedEN()
{
        publicacionLinPed = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN>();
}



public LinPedEN(int id, string cantidad, string precio, ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedidoLinPed, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> publicacionLinPed
                )
{
        this.init (Id, cantidad, precio, pedidoLinPed, publicacionLinPed);
}


public LinPedEN(LinPedEN linPed)
{
        this.init (linPed.Id, linPed.Cantidad, linPed.Precio, linPed.PedidoLinPed, linPed.PublicacionLinPed);
}

private void init (int id
                   , string cantidad, string precio, ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedidoLinPed, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> publicacionLinPed)
{
        this.Id = id;


        this.Cantidad = cantidad;

        this.Precio = precio;

        this.PedidoLinPed = pedidoLinPed;

        this.PublicacionLinPed = publicacionLinPed;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LinPedEN t = obj as LinPedEN;
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
