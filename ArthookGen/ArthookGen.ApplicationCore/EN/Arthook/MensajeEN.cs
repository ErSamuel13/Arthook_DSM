
using System;
// Definición clase MensajeEN
namespace ArthookGen.ApplicationCore.EN.Arthook
{
public partial class MensajeEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo contenido
 */
private string contenido;



/**
 *	Atributo emisor
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN emisor;



/**
 *	Atributo receptor
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN receptor;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual string Contenido {
        get { return contenido; } set { contenido = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN Emisor {
        get { return emisor; } set { emisor = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN Receptor {
        get { return receptor; } set { receptor = value;  }
}





public MensajeEN()
{
}



public MensajeEN(int id, Nullable<DateTime> fecha, string contenido, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN emisor, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN receptor
                 )
{
        this.init (Id, fecha, contenido, emisor, receptor);
}


public MensajeEN(MensajeEN mensaje)
{
        this.init (mensaje.Id, mensaje.Fecha, mensaje.Contenido, mensaje.Emisor, mensaje.Receptor);
}

private void init (int id
                   , Nullable<DateTime> fecha, string contenido, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN emisor, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN receptor)
{
        this.Id = id;


        this.Fecha = fecha;

        this.Contenido = contenido;

        this.Emisor = emisor;

        this.Receptor = receptor;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MensajeEN t = obj as MensajeEN;
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
