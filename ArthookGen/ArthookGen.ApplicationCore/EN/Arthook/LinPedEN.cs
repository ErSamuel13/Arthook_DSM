
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
 *	Atributo precio
 */
private float precio;



/**
 *	Atributo pedido
 */
private ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedido;



/**
 *	Atributo publicacion
 */
private ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN publicacion;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual float Precio {
        get { return precio; } set { precio = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN Publicacion {
        get { return publicacion; } set { publicacion = value;  }
}





public LinPedEN()
{
}



public LinPedEN(int id, int cantidad, float precio, ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedido, ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN publicacion
                )
{
        this.init (Id, cantidad, precio, pedido, publicacion);
}


public LinPedEN(LinPedEN linPed)
{
        this.init (linPed.Id, linPed.Cantidad, linPed.Precio, linPed.Pedido, linPed.Publicacion);
}

private void init (int id
                   , int cantidad, float precio, ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedido, ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN publicacion)
{
        this.Id = id;


        this.Cantidad = cantidad;

        this.Precio = precio;

        this.Pedido = pedido;

        this.Publicacion = publicacion;
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
