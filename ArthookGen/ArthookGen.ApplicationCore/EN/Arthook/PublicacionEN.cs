
using System;
// Definición clase PublicacionEN
namespace ArthookGen.ApplicationCore.EN.Arthook
{
public partial class PublicacionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo pvp
 */
private float pvp;



/**
 *	Atributo tipo
 */
private ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum tipo;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo tipoPublicacion
 */
private ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum tipoPublicacion;



/**
 *	Atributo usuarioPublicacion
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioPublicacion;



/**
 *	Atributo valoracionPublicacion
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracionPublicacion;



/**
 *	Atributo linPedPublicacion
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN> linPedPublicacion;



/**
 *	Atributo imagen
 */
private string imagen;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual float Pvp {
        get { return pvp; } set { pvp = value;  }
}



public virtual ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum TipoPublicacion {
        get { return tipoPublicacion; } set { tipoPublicacion = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN UsuarioPublicacion {
        get { return usuarioPublicacion; } set { usuarioPublicacion = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> ValoracionPublicacion {
        get { return valoracionPublicacion; } set { valoracionPublicacion = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN> LinPedPublicacion {
        get { return linPedPublicacion; } set { linPedPublicacion = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}





public PublicacionEN()
{
        valoracionPublicacion = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN>();
        linPedPublicacion = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN>();
}



public PublicacionEN(int id, float pvp, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum tipo, string descripcion, string titulo, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum tipoPublicacion, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioPublicacion, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracionPublicacion, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN> linPedPublicacion, string imagen
                     )
{
        this.init (Id, pvp, tipo, descripcion, titulo, tipoPublicacion, usuarioPublicacion, valoracionPublicacion, linPedPublicacion, imagen);
}


public PublicacionEN(PublicacionEN publicacion)
{
        this.init (publicacion.Id, publicacion.Pvp, publicacion.Tipo, publicacion.Descripcion, publicacion.Titulo, publicacion.TipoPublicacion, publicacion.UsuarioPublicacion, publicacion.ValoracionPublicacion, publicacion.LinPedPublicacion, publicacion.Imagen);
}

private void init (int id
                   , float pvp, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum tipo, string descripcion, string titulo, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum tipoPublicacion, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuarioPublicacion, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracionPublicacion, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.LinPedEN> linPedPublicacion, string imagen)
{
        this.Id = id;


        this.Pvp = pvp;

        this.Tipo = tipo;

        this.Descripcion = descripcion;

        this.Titulo = titulo;

        this.TipoPublicacion = tipoPublicacion;

        this.UsuarioPublicacion = usuarioPublicacion;

        this.ValoracionPublicacion = valoracionPublicacion;

        this.LinPedPublicacion = linPedPublicacion;

        this.Imagen = imagen;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PublicacionEN t = obj as PublicacionEN;
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
