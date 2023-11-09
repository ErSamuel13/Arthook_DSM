
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
private int cantidad;



/**
 *	Atributo precioT
 */
private float precioT;



/**
 *	Atributo pedidoLinPed
 */
private ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedidoLinPed;



/**
 *	Atributo publicacionLinPed
 */
private ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN publicacionLinPed;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual float PrecioT {
        get { return precioT; } set { precioT = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.PedidoEN PedidoLinPed {
        get { return pedidoLinPed; } set { pedidoLinPed = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN PublicacionLinPed {
        get { return publicacionLinPed; } set { publicacionLinPed = value;  }
}





public LinPedEN()
{
}



public LinPedEN(int id, int cantidad, float precioT, ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedidoLinPed, ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN publicacionLinPed
                )
{
        this.init (Id, cantidad, precioT, pedidoLinPed, publicacionLinPed);
}


public LinPedEN(LinPedEN linPed)
{
        this.init (linPed.Id, linPed.Cantidad, linPed.PrecioT, linPed.PedidoLinPed, linPed.PublicacionLinPed);
}

private void init (int id
                   , int cantidad, float precioT, ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedidoLinPed, ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN publicacionLinPed)
{
        this.Id = id;


        this.Cantidad = cantidad;

        this.PrecioT = precioT;

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
