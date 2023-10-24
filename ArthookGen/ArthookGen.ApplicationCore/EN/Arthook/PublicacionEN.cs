
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
 *	Atributo valoracionMedia
 */
private float valoracionMedia;



/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo tipoPubli
 */
private ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum tipoPubli;



/**
 *	Atributo usuario
 */
private ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario;



/**
 *	Atributo valoracion
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracion;



/**
 *	Atributo linPed
 */
private ArthookGen.ApplicationCore.EN.Arthook.LinPedEN linPed;






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



public virtual float ValoracionMedia {
        get { return valoracionMedia; } set { valoracionMedia = value;  }
}



public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum TipoPubli {
        get { return tipoPubli; } set { tipoPubli = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}



public virtual ArthookGen.ApplicationCore.EN.Arthook.LinPedEN LinPed {
        get { return linPed; } set { linPed = value;  }
}





public PublicacionEN()
{
        valoracion = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN>();
}



public PublicacionEN(int id, float pvp, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum tipo, string descripcion, float valoracionMedia, string titulo, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum tipoPubli, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracion, ArthookGen.ApplicationCore.EN.Arthook.LinPedEN linPed
                     )
{
        this.init (Id, pvp, tipo, descripcion, valoracionMedia, titulo, tipoPubli, usuario, valoracion, linPed);
}


public PublicacionEN(PublicacionEN publicacion)
{
        this.init (publicacion.Id, publicacion.Pvp, publicacion.Tipo, publicacion.Descripcion, publicacion.ValoracionMedia, publicacion.Titulo, publicacion.TipoPubli, publicacion.Usuario, publicacion.Valoracion, publicacion.LinPed);
}

private void init (int id
                   , float pvp, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum tipo, string descripcion, float valoracionMedia, string titulo, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum tipoPubli, ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN usuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracion, ArthookGen.ApplicationCore.EN.Arthook.LinPedEN linPed)
{
        this.Id = id;


        this.Pvp = pvp;

        this.Tipo = tipo;

        this.Descripcion = descripcion;

        this.ValoracionMedia = valoracionMedia;

        this.Titulo = titulo;

        this.TipoPubli = tipoPubli;

        this.Usuario = usuario;

        this.Valoracion = valoracion;

        this.LinPed = linPed;
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
