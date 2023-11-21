
using System;
using System.Text;
using System.Collections.Generic;
using ArthookGen.ApplicationCore.Exceptions;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;


/*PROTECTED REGION ID(usingArthookGen.ApplicationCore.CEN.Arthook_Usuario_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ArthookGen.ApplicationCore.CEN.Arthook
{
public partial class UsuarioCEN
{
public int New_ (string p_nombre, string p_email, string p_nickname, ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum p_tipoUsuario, String p_pass)
{
        /*PROTECTED REGION ID(ArthookGen.ApplicationCore.CEN.Arthook_Usuario_new__customized) ENABLED START*/

        UsuarioEN usuarioEN = null;

        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nombre = p_nombre;

        usuarioEN.Email = p_email;

        usuarioEN.Nickname = p_nickname;

        usuarioEN.TipoUsuario = p_tipoUsuario;

        usuarioEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        usuarioEN.ValoracionMedia = 0;
        //Call to UsuarioRepository

        oid = _IUsuarioRepository.New_ (usuarioEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
