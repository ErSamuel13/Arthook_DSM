
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
private string puntuacion;



/**
 *	Atributo comentario
 */
private string comentario;



/**
 *	Atributo usuarioValoracion
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioValoracion;



/**
 *	Atributo publicacionValoracion
 */
private ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN publicacionValoracion;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual string Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN UsuarioValoracion {
        get { return usuarioValoracion; } set { usuarioValoracion = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN PublicacionValoracion {
        get { return publicacionValoracion; } set { publicacionValoracion = value;  }
}





public ValoracionPublicacionEN()
{
}



public ValoracionPublicacionEN(int id, string puntuacion, string comentario, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioValoracion, ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN publicacionValoracion
                               )
{
        this.init (Id, puntuacion, comentario, usuarioValoracion, publicacionValoracion);
}


public ValoracionPublicacionEN(ValoracionPublicacionEN valoracionPublicacion)
{
        this.init (valoracionPublicacion.Id, valoracionPublicacion.Puntuacion, valoracionPublicacion.Comentario, valoracionPublicacion.UsuarioValoracion, valoracionPublicacion.PublicacionValoracion);
}

private void init (int id
                   , string puntuacion, string comentario, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioValoracion, ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN publicacionValoracion)
{
        this.Id = id;


        this.Puntuacion = puntuacion;

        this.Comentario = comentario;

        this.UsuarioValoracion = usuarioValoracion;

        this.PublicacionValoracion = publicacionValoracion;
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
