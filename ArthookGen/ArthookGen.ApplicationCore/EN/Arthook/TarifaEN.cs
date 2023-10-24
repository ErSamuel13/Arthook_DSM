
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
private float precio;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo usuario
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual float Precio {
        get { return precio; } set { precio = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public TarifaEN()
{
}



public TarifaEN(int id, float precio, string descripcion, string nombre, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario
                )
{
        this.init (Id, precio, descripcion, nombre, usuario);
}


public TarifaEN(TarifaEN tarifa)
{
        this.init (tarifa.Id, tarifa.Precio, tarifa.Descripcion, tarifa.Nombre, tarifa.Usuario);
}

private void init (int id
                   , float precio, string descripcion, string nombre, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario)
{
        this.Id = id;


        this.Precio = precio;

        this.Descripcion = descripcion;

        this.Nombre = nombre;

        this.Usuario = usuario;
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
