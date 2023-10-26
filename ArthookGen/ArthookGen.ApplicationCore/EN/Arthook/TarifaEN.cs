
using System;
// Definición clase TarifaEN
namespace ArthookGen.ApplicationCore.EN.Arthook
{
public partial class TarifaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo precio
 */
private string precio;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo usuarioTarifa
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioTarifa;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Precio {
        get { return precio; } set { precio = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN UsuarioTarifa {
        get { return usuarioTarifa; } set { usuarioTarifa = value;  }
}





public TarifaEN()
{
}



public TarifaEN(int id, string precio, string descripcion, string nombre, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioTarifa
                )
{
        this.init (Id, precio, descripcion, nombre, usuarioTarifa);
}


public TarifaEN(TarifaEN tarifa)
{
        this.init (tarifa.Id, tarifa.Precio, tarifa.Descripcion, tarifa.Nombre, tarifa.UsuarioTarifa);
}

private void init (int id
                   , string precio, string descripcion, string nombre, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioTarifa)
{
        this.Id = id;


        this.Precio = precio;

        this.Descripcion = descripcion;

        this.Nombre = nombre;

        this.UsuarioTarifa = usuarioTarifa;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TarifaEN t = obj as TarifaEN;
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
