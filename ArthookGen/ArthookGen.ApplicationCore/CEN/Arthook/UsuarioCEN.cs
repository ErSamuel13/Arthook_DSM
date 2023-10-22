

using System;
using System.Text;
using System.Collections.Generic;

using ArthookGen.ApplicationCore.Exceptions;

using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;


namespace ArthookGen.ApplicationCore.CEN.Arthook
{
/*
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioRepository _IUsuarioRepository;

public UsuarioCEN(IUsuarioRepository _IUsuarioRepository)
{
        this._IUsuarioRepository = _IUsuarioRepository;
}

public IUsuarioRepository get_IUsuarioRepository ()
{
        return this._IUsuarioRepository;
}

public int New_ (string p_nombre, string p_email, string p_nickname, String p_password, string p_telefono, System.Collections.Generic.IList<int> p_mensajeE, System.Collections.Generic.IList<int> p_mensajeR, int p_publicacion, int p_tarifa, int p_valoracion)
{
        UsuarioEN usuarioEN = null;
        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nombre = p_nombre;

        usuarioEN.Email = p_email;

        usuarioEN.Nickname = p_nickname;

        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        usuarioEN.Telefono = p_telefono;


        usuarioEN.MensajeE = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN>();
        if (p_mensajeE != null) {
                foreach (int item in p_mensajeE) {
                        ArthookGen.ApplicationCore.EN.Arthook.MensajeEN en = new ArthookGen.ApplicationCore.EN.Arthook.MensajeEN ();
                        en.Id = item;
                        usuarioEN.MensajeE.Add (en);
                }
        }

        else{
                usuarioEN.MensajeE = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN>();
        }


        usuarioEN.MensajeR = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN>();
        if (p_mensajeR != null) {
                foreach (int item in p_mensajeR) {
                        ArthookGen.ApplicationCore.EN.Arthook.MensajeEN en = new ArthookGen.ApplicationCore.EN.Arthook.MensajeEN ();
                        en.Id = item;
                        usuarioEN.MensajeR.Add (en);
                }
        }

        else{
                usuarioEN.MensajeR = new System.Collections.Generic.List<ArthookGen.ApplicationCore.EN.Arthook.MensajeEN>();
        }


        if (p_publicacion != -1) {
                // El argumento p_publicacion -> Property publicacion es oid = false
                // Lista de oids id
                usuarioEN.Publicacion = new ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN ();
                usuarioEN.Publicacion.Id = p_publicacion;
        }


        if (p_tarifa != -1) {
                // El argumento p_tarifa -> Property tarifa es oid = false
                // Lista de oids id
                usuarioEN.Tarifa = new ArthookGen.ApplicationCore.EN.Arthook.TarifaEN ();
                usuarioEN.Tarifa.Id = p_tarifa;
        }


        if (p_valoracion != -1) {
                // El argumento p_valoracion -> Property valoracion es oid = false
                // Lista de oids id
                usuarioEN.Valoracion = new ArthookGen.ApplicationCore.EN.Arthook.ValoracionEN ();
                usuarioEN.Valoracion.Id = p_valoracion;
        }



        oid = _IUsuarioRepository.New_ (usuarioEN);
        return oid;
}

public void Modify (int p_Usuario_OID, string p_nombre, string p_email, string p_nickname, String p_password, string p_telefono)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Id = p_Usuario_OID;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Email = p_email;
        usuarioEN.Nickname = p_nickname;
        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        usuarioEN.Telefono = p_telefono;
        //Call to UsuarioRepository

        _IUsuarioRepository.Modify (usuarioEN);
}

public void Destroy (int id
                     )
{
        _IUsuarioRepository.Destroy (id);
}

public UsuarioEN ReadOID (int id
                          )
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioRepository.ReadOID (id);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioRepository.ReadAll (first, size);
        return list;
}
}
}
