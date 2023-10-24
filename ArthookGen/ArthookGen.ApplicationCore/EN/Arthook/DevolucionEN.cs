
using System;
// Definición clase DevolucionEN
namespace ArthookGen.ApplicationCore.EN.Arthook
{
public partial class DevolucionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo motivo
 */
private ArthookGen.ApplicationCore.Enumerated.Arthook.MotivoEnum motivo;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo usuario
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario;



/**
 *	Atributo pedido
 */
private ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedido;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual ArthookGen.ApplicationCore.Enumerated.Arthook.MotivoEnum Motivo {
        get { return motivo; } set { motivo = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}





public DevolucionEN()
{
}



public DevolucionEN(int id, string descripcion, ArthookGen.ApplicationCore.Enumerated.Arthook.MotivoEnum motivo, Nullable<DateTime> fecha, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario, ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedido
                    )
{
        this.init (Id, descripcion, motivo, fecha, usuario, pedido);
}


public DevolucionEN(DevolucionEN devolucion)
{
        this.init (devolucion.Id, devolucion.Descripcion, devolucion.Motivo, devolucion.Fecha, devolucion.Usuario, devolucion.Pedido);
}

private void init (int id
                   , string descripcion, ArthookGen.ApplicationCore.Enumerated.Arthook.MotivoEnum motivo, Nullable<DateTime> fecha, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario, ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedido)
{
        this.Id = id;


        this.Descripcion = descripcion;

        this.Motivo = motivo;

        this.Fecha = fecha;

        this.Usuario = usuario;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DevolucionEN t = obj as DevolucionEN;
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
