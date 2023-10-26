
using System;
// Definición clase ValoracionUsuarioEN
namespace ArthookGen.ApplicationCore.EN.Arthook
{
public partial class ValoracionUsuarioEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo puntuacion
 */
private string puntuacion;



/**
 *	Atributo valorador
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN valorador;



/**
 *	Atributo valorado
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN valorado;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN Valorador {
        get { return valorador; } set { valorador = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN Valorado {
        get { return valorado; } set { valorado = value;  }
}





public ValoracionUsuarioEN()
{
}



public ValoracionUsuarioEN(int id, string puntuacion, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN valorador, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN valorado
                           )
{
        this.init (Id, puntuacion, valorador, valorado);
}


public ValoracionUsuarioEN(ValoracionUsuarioEN valoracionUsuario)
{
        this.init (valoracionUsuario.Id, valoracionUsuario.Puntuacion, valoracionUsuario.Valorador, valoracionUsuario.Valorado);
}

private void init (int id
                   , string puntuacion, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN valorador, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN valorado)
{
        this.Id = id;


        this.Puntuacion = puntuacion;

        this.Valorador = valorador;

        this.Valorado = valorado;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionUsuarioEN t = obj as ValoracionUsuarioEN;
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
