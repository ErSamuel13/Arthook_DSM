
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
 *	Atributo usuarioDevolucion
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioDevolucion;



/**
 *	Atributo pedidoDevolucion
 */
private ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedidoDevolucion;






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



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN UsuarioDevolucion {
        get { return usuarioDevolucion; } set { usuarioDevolucion = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.PedidoEN PedidoDevolucion {
        get { return pedidoDevolucion; } set { pedidoDevolucion = value;  }
}





public DevolucionEN()
{
}



public DevolucionEN(int id, string descripcion, ArthookGen.ApplicationCore.Enumerated.Arthook.MotivoEnum motivo, Nullable<DateTime> fecha, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioDevolucion, ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedidoDevolucion
                    )
{
        this.init (Id, descripcion, motivo, fecha, usuarioDevolucion, pedidoDevolucion);
}


public DevolucionEN(DevolucionEN devolucion)
{
        this.init (devolucion.Id, devolucion.Descripcion, devolucion.Motivo, devolucion.Fecha, devolucion.UsuarioDevolucion, devolucion.PedidoDevolucion);
}

private void init (int id
                   , string descripcion, ArthookGen.ApplicationCore.Enumerated.Arthook.MotivoEnum motivo, Nullable<DateTime> fecha, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioDevolucion, ArthookGen.ApplicationCore.EN.Arthook.PedidoEN pedidoDevolucion)
{
        this.Id = id;


        this.Descripcion = descripcion;

        this.Motivo = motivo;

        this.Fecha = fecha;

        this.UsuarioDevolucion = usuarioDevolucion;

        this.PedidoDevolucion = pedidoDevolucion;
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
