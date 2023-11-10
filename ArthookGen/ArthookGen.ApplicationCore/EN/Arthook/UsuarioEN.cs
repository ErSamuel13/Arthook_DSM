<<<<<<< HEAD

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
 *	Atributo pass
 */
private String pass;



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
 *	Atributo valoracionMedia
 */
private string valoracionMedia;



/**
 *	Atributo tipoUsuario
 */
private ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum tipoUsuario;



/**
 *	Atributo mensajeE
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeE;



/**
 *	Atributo mensajeR
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeR;



/**
 *	Atributo valoracionEmitida
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionEmitida;



/**
 *	Atributo tarifa
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN> tarifa;



/**
 *	Atributo publicacionUsuario
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> publicacionUsuario;



/**
 *	Atributo valoracionPublicacionUsuaro
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracionPublicacionUsuaro;



/**
 *	Atributo pedidoUsuario
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> pedidoUsuario;



/**
 *	Atributo devolucionUsuario
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN> devolucionUsuario;



/**
 *	Atributo metodoPagoUsuario
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN> metodoPagoUsuario;



/**
 *	Atributo valoracionRecibida
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionRecibida;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
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



public virtual string ValoracionMedia {
        get { return valoracionMedia; } set { valoracionMedia = value;  }
}



public virtual ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum TipoUsuario {
        get { return tipoUsuario; } set { tipoUsuario = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> MensajeE {
        get { return mensajeE; } set { mensajeE = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> MensajeR {
        get { return mensajeR; } set { mensajeR = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> ValoracionEmitida {
        get { return valoracionEmitida; } set { valoracionEmitida = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN> Tarifa {
        get { return tarifa; } set { tarifa = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> PublicacionUsuario {
        get { return publicacionUsuario; } set { publicacionUsuario = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> ValoracionPublicacionUsuaro {
        get { return valoracionPublicacionUsuaro; } set { valoracionPublicacionUsuaro = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> PedidoUsuario {
        get { return pedidoUsuario; } set { pedidoUsuario = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN> DevolucionUsuario {
        get { return devolucionUsuario; } set { devolucionUsuario = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN> MetodoPagoUsuario {
        get { return metodoPagoUsuario; } set { metodoPagoUsuario = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> ValoracionRecibida {
        get { return valoracionRecibida; } set { valoracionRecibida = value;  }
}





public UsuarioEN()
{
        mensajeE = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN>();
        mensajeR = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN>();
        valoracionEmitida = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN>();
        tarifa = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN>();
        publicacionUsuario = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN>();
        valoracionPublicacionUsuaro = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN>();
        pedidoUsuario = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN>();
        devolucionUsuario = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN>();
        metodoPagoUsuario = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN>();
        valoracionRecibida = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN>();
}



public UsuarioEN(int id, String pass, string nombre, string email, string nickname, string valoracionMedia, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum tipoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeE, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeR, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionEmitida, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN> tarifa, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> publicacionUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracionPublicacionUsuaro, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> pedidoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN> devolucionUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN> metodoPagoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionRecibida
                 )
{
        this.init (Id, pass, nombre, email, nickname, valoracionMedia, tipoUsuario, mensajeE, mensajeR, valoracionEmitida, tarifa, publicacionUsuario, valoracionPublicacionUsuaro, pedidoUsuario, devolucionUsuario, metodoPagoUsuario, valoracionRecibida);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.Id, usuario.Pass, usuario.Nombre, usuario.Email, usuario.Nickname, usuario.ValoracionMedia, usuario.TipoUsuario, usuario.MensajeE, usuario.MensajeR, usuario.ValoracionEmitida, usuario.Tarifa, usuario.PublicacionUsuario, usuario.ValoracionPublicacionUsuaro, usuario.PedidoUsuario, usuario.DevolucionUsuario, usuario.MetodoPagoUsuario, usuario.ValoracionRecibida);
}

private void init (int id
                   , String pass, string nombre, string email, string nickname, string valoracionMedia, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum tipoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeE, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeR, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionEmitida, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN> tarifa, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> publicacionUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracionPublicacionUsuaro, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> pedidoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN> devolucionUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN> metodoPagoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionRecibida)
{
        this.Id = id;


        this.Pass = pass;

        this.Nombre = nombre;

        this.Email = email;

        this.Nickname = nickname;

        this.ValoracionMedia = valoracionMedia;

        this.TipoUsuario = tipoUsuario;

        this.MensajeE = mensajeE;

        this.MensajeR = mensajeR;

        this.ValoracionEmitida = valoracionEmitida;

        this.Tarifa = tarifa;

        this.PublicacionUsuario = publicacionUsuario;

        this.ValoracionPublicacionUsuaro = valoracionPublicacionUsuaro;

        this.PedidoUsuario = pedidoUsuario;

        this.DevolucionUsuario = devolucionUsuario;

        this.MetodoPagoUsuario = metodoPagoUsuario;

        this.ValoracionRecibida = valoracionRecibida;
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
=======

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
 *	Atributo valoracionMedia
 */
private float valoracionMedia;



/**
 *	Atributo tipoUsuario
 */
private ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum tipoUsuario;



/**
 *	Atributo mensajeE
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeE;



/**
 *	Atributo mensajeR
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeR;



/**
 *	Atributo valoracionEmitida
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionEmitida;



/**
 *	Atributo tarifa
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN> tarifa;



/**
 *	Atributo publicacionUsuario
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> publicacionUsuario;



/**
 *	Atributo valoracionPublicacionUsuaro
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracionPublicacionUsuaro;



/**
 *	Atributo pedidoUsuario
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> pedidoUsuario;



/**
 *	Atributo devolucionUsuario
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN> devolucionUsuario;



/**
 *	Atributo metodoPagoUsuario
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN> metodoPagoUsuario;



/**
 *	Atributo valoracionRecibida
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionRecibida;



/**
 *	Atributo pass
 */
private String pass;



/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> usuario;



/**
 *	Atributo usuario_0
 */
private System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> usuario_0;






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



public virtual float ValoracionMedia {
        get { return valoracionMedia; } set { valoracionMedia = value;  }
}



public virtual ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum TipoUsuario {
        get { return tipoUsuario; } set { tipoUsuario = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> MensajeE {
        get { return mensajeE; } set { mensajeE = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> MensajeR {
        get { return mensajeR; } set { mensajeR = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> ValoracionEmitida {
        get { return valoracionEmitida; } set { valoracionEmitida = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN> Tarifa {
        get { return tarifa; } set { tarifa = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> PublicacionUsuario {
        get { return publicacionUsuario; } set { publicacionUsuario = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> ValoracionPublicacionUsuaro {
        get { return valoracionPublicacionUsuaro; } set { valoracionPublicacionUsuaro = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> PedidoUsuario {
        get { return pedidoUsuario; } set { pedidoUsuario = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN> DevolucionUsuario {
        get { return devolucionUsuario; } set { devolucionUsuario = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN> MetodoPagoUsuario {
        get { return metodoPagoUsuario; } set { metodoPagoUsuario = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> ValoracionRecibida {
        get { return valoracionRecibida; } set { valoracionRecibida = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> Usuario_0 {
        get { return usuario_0; } set { usuario_0 = value;  }
}





public UsuarioEN()
{
        mensajeE = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN>();
        mensajeR = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN>();
        valoracionEmitida = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN>();
        tarifa = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN>();
        publicacionUsuario = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN>();
        valoracionPublicacionUsuaro = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN>();
        pedidoUsuario = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN>();
        devolucionUsuario = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN>();
        metodoPagoUsuario = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN>();
        valoracionRecibida = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN>();
        usuario = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN>();
        usuario_0 = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN>();
}



public UsuarioEN(int id, string nombre, string email, string nickname, float valoracionMedia, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum tipoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeE, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeR, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionEmitida, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN> tarifa, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> publicacionUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracionPublicacionUsuaro, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> pedidoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN> devolucionUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN> metodoPagoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionRecibida, String pass, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> usuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> usuario_0
                 )
{
        this.init (Id, nombre, email, nickname, valoracionMedia, tipoUsuario, mensajeE, mensajeR, valoracionEmitida, tarifa, publicacionUsuario, valoracionPublicacionUsuaro, pedidoUsuario, devolucionUsuario, metodoPagoUsuario, valoracionRecibida, pass, usuario, usuario_0);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.Id, usuario.Nombre, usuario.Email, usuario.Nickname, usuario.ValoracionMedia, usuario.TipoUsuario, usuario.MensajeE, usuario.MensajeR, usuario.ValoracionEmitida, usuario.Tarifa, usuario.PublicacionUsuario, usuario.ValoracionPublicacionUsuaro, usuario.PedidoUsuario, usuario.DevolucionUsuario, usuario.MetodoPagoUsuario, usuario.ValoracionRecibida, usuario.Pass, usuario.Usuario, usuario.Usuario_0);
}

private void init (int id
                   , string nombre, string email, string nickname, float valoracionMedia, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum tipoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeE, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN> mensajeR, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionEmitida, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.TarifaEN> tarifa, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> publicacionUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> valoracionPublicacionUsuaro, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PedidoEN> pedidoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.DevolucionEN> devolucionUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.MetodoPagoEN> metodoPagoUsuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> valoracionRecibida, String pass, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> usuario, System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN> usuario_0)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Email = email;

        this.Nickname = nickname;

        this.ValoracionMedia = valoracionMedia;

        this.TipoUsuario = tipoUsuario;

        this.MensajeE = mensajeE;

        this.MensajeR = mensajeR;

        this.ValoracionEmitida = valoracionEmitida;

        this.Tarifa = tarifa;

        this.PublicacionUsuario = publicacionUsuario;

        this.ValoracionPublicacionUsuaro = valoracionPublicacionUsuaro;

        this.PedidoUsuario = pedidoUsuario;

        this.DevolucionUsuario = devolucionUsuario;

        this.MetodoPagoUsuario = metodoPagoUsuario;

        this.ValoracionRecibida = valoracionRecibida;

        this.Pass = pass;

        this.Usuario = usuario;

        this.Usuario_0 = usuario_0;
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
>>>>>>> Developer
