
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
private float puntuacion;



/**
 *	Atributo usuarioValorador
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioValorador;



/**
 *	Atributo usuarioValorado
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioValorado;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual float Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN UsuarioValorador {
        get { return usuarioValorador; } set { usuarioValorador = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN UsuarioValorado {
        get { return usuarioValorado; } set { usuarioValorado = value;  }
}





public ValoracionUsuarioEN()
{
}



public ValoracionUsuarioEN(int id, float puntuacion, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioValorador, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioValorado
                           )
{
        this.init (Id, puntuacion, usuarioValorador, usuarioValorado);
}


public ValoracionUsuarioEN(ValoracionUsuarioEN valoracionUsuario)
{
        this.init (valoracionUsuario.Id, valoracionUsuario.Puntuacion, valoracionUsuario.UsuarioValorador, valoracionUsuario.UsuarioValorado);
}

private void init (int id
                   , float puntuacion, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioValorador, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioValorado)
{
        this.Id = id;


        this.Puntuacion = puntuacion;

        this.UsuarioValorador = usuarioValorador;

        this.UsuarioValorado = usuarioValorado;
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
