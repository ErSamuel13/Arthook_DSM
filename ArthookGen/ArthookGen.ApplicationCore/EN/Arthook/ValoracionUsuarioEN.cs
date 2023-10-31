
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
 *	Atributo emVal
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN emVal;



/**
 *	Atributo reVal
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN reVal;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN EmVal {
        get { return emVal; } set { emVal = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ReVal {
        get { return reVal; } set { reVal = value;  }
}





public ValoracionUsuarioEN()
{
}



public ValoracionUsuarioEN(int id, string puntuacion, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN emVal, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN reVal
                           )
{
        this.init (Id, puntuacion, emVal, reVal);
}


public ValoracionUsuarioEN(ValoracionUsuarioEN valoracionUsuario)
{
        this.init (valoracionUsuario.Id, valoracionUsuario.Puntuacion, valoracionUsuario.EmVal, valoracionUsuario.ReVal);
}

private void init (int id
                   , string puntuacion, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN emVal, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN reVal)
{
        this.Id = id;


        this.Puntuacion = puntuacion;

        this.EmVal = emVal;

        this.ReVal = reVal;
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
