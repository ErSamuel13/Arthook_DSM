
using System;
using System.Text;

using System.Collections.Generic;
using ArthookGen.ApplicationCore.Exceptions;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;
using ArthookGen.ApplicationCore.CEN.Arthook;



/*PROTECTED REGION ID(usingArthookGen.ApplicationCore.CP.Arthook_Usuario_CambiarTipo) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ArthookGen.ApplicationCore.CP.Arthook
{
public partial class UsuarioCP : GenericBasicCP
{
public void CambiarTipo (int p_oid)
{
        /*PROTECTED REGION ID(ArthookGen.ApplicationCore.CP.Arthook_Usuario_CambiarTipo) ENABLED START*/

        UsuarioCEN usuarioCEN = null;



        try
        {
                CPSession.SessionInitializeTransaction ();
                usuarioCEN = new  UsuarioCEN (CPSession.UnitRepo.UsuarioRepository);
                UsuarioEN usuarioEN = usuarioCEN.ReadOID (p_oid);
                usuarioEN.TipoUsuario = Enumerated.Arthook.TipoUsuarioEnum.usuario;
                usuarioCEN.get_IUsuarioRepository ().ModifyDefault (usuarioEN);
                CPSession.Commit ();
        }
        catch (Exception ex)
        {
                CPSession.RollBack ();
                throw ex;
        }
        finally
        {
                CPSession.SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
