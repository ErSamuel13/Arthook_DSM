
using System;
// Definición clase UsuarioEN
namespace ArthookGen.ApplicationCore.EN.Arthook
{
public partial class UsuarioEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo nickname
 */
private string nickname;



/**
 *	Atributo telefono
 */
private string telefono;



/**
 *	Atributo mensajeE
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeE;



/**
 *	Atributo mensajeR
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeR;



/**
 *	Atributo publicacion
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> publicacion;



/**
 *	Atributo tarifa
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN> tarifa;



/**
 *	Atributo valoracion
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracion;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> pedido;



/**
 *	Atributo devolucion
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN> devolucion;



/**
 *	Atributo tipoUsuario
 */
private ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum tipoUsuario;



/**
 *	Atributo metodoPago
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN> metodoPago;



/**
 *	Atributo valoracionMedia
 */
private double valoracionMedia;



/**
 *	Atributo valoracionEmitidas
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionEmitidas;



/**
 *	Atributo valoracionRecibidas
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionRecibidas;



/**
 *	Atributo pass
 */
private String pass;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Nickname {
        get { return nickname; } set { nickname = value;  }
}



public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> MensajeE {
        get { return mensajeE; } set { mensajeE = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> MensajeR {
        get { return mensajeR; } set { mensajeR = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> Publicacion {
        get { return publicacion; } set { publicacion = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN> Tarifa {
        get { return tarifa; } set { tarifa = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN> Devolucion {
        get { return devolucion; } set { devolucion = value;  }
}



public virtual ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum TipoUsuario {
        get { return tipoUsuario; } set { tipoUsuario = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN> MetodoPago {
        get { return metodoPago; } set { metodoPago = value;  }
}



public virtual double ValoracionMedia {
        get { return valoracionMedia; } set { valoracionMedia = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> ValoracionEmitidas {
        get { return valoracionEmitidas; } set { valoracionEmitidas = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> ValoracionRecibidas {
        get { return valoracionRecibidas; } set { valoracionRecibidas = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}





public UsuarioEN()
{
        mensajeE = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN>();
        mensajeR = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN>();
        publicacion = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN>();
        tarifa = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN>();
        valoracion = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN>();
        pedido = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN>();
        devolucion = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN>();
        metodoPago = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN>();
        valoracionEmitidas = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN>();
        valoracionRecibidas = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN>();
}



public UsuarioEN(int id, string nombre, string email, string nickname, string telefono, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeE, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeR, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> publicacion, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN> tarifa, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracion, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> pedido, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN> devolucion, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum tipoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN> metodoPago, double valoracionMedia, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionEmitidas, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionRecibidas, String pass
                 )
{
        this.init (Id, nombre, email, nickname, telefono, mensajeE, mensajeR, publicacion, tarifa, valoracion, pedido, devolucion, tipoUsuario, metodoPago, valoracionMedia, valoracionEmitidas, valoracionRecibidas, pass);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.Id, usuario.Nombre, usuario.Email, usuario.Nickname, usuario.Telefono, usuario.MensajeE, usuario.MensajeR, usuario.Publicacion, usuario.Tarifa, usuario.Valoracion, usuario.Pedido, usuario.Devolucion, usuario.TipoUsuario, usuario.MetodoPago, usuario.ValoracionMedia, usuario.ValoracionEmitidas, usuario.ValoracionRecibidas, usuario.Pass);
}

private void init (int id
                   , string nombre, string email, string nickname, string telefono, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeE, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeR, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> publicacion, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN> tarifa, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracion, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> pedido, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN> devolucion, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum tipoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN> metodoPago, double valoracionMedia, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionEmitidas, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionRecibidas, String pass)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Email = email;

        this.Nickname = nickname;

        this.Telefono = telefono;

        this.MensajeE = mensajeE;

        this.MensajeR = mensajeR;

        this.Publicacion = publicacion;

        this.Tarifa = tarifa;

        this.Valoracion = valoracion;

        this.Pedido = pedido;

        this.Devolucion = devolucion;

        this.TipoUsuario = tipoUsuario;

        this.MetodoPago = metodoPago;

        this.ValoracionMedia = valoracionMedia;

        this.ValoracionEmitidas = valoracionEmitidas;

        this.ValoracionRecibidas = valoracionRecibidas;

        this.Pass = pass;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
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
