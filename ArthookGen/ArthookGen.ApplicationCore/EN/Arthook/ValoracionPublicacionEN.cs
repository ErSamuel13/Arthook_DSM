
using System;
// Definición clase ValoracionPublicacionEN
namespace ArthookGen.ApplicationCore.EN.Arthook
{
public partial class ValoracionPublicacionEN
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
 *	Atributo comentario
 */
private string comentario;



/**
 *	Atributo publicacion
 */
private ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN publicacion;



/**
 *	Atributo usuario
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual float Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual string Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN Publicacion {
        get { return publicacion; } set { publicacion = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public ValoracionPublicacionEN()
{
}



public ValoracionPublicacionEN(int id, float puntuacion, string comentario, ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN publicacion, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario
                               )
{
        this.init (Id, puntuacion, comentario, publicacion, usuario);
}


public ValoracionPublicacionEN(ValoracionPublicacionEN valoracionPublicacion)
{
        this.init (valoracionPublicacion.Id, valoracionPublicacion.Puntuacion, valoracionPublicacion.Comentario, valoracionPublicacion.Publicacion, valoracionPublicacion.Usuario);
}

private void init (int id
                   , float puntuacion, string comentario, ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN publicacion, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario)
{
        this.Id = id;


        this.Puntuacion = puntuacion;

        this.Comentario = comentario;

        this.Publicacion = publicacion;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionPublicacionEN t = obj as ValoracionPublicacionEN;
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
