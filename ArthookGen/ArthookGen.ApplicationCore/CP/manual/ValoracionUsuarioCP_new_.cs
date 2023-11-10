
using System;
using System.Text;

using System.Collections.Generic;
using ArthookGen.ApplicationCore.Exceptions;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;
using ArthookGen.ApplicationCore.CEN.Arthook;



/*PROTECTED REGION ID(usingArthookGen.ApplicationCore.CP.Arthook_ValoracionUsuario_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ArthookGen.ApplicationCore.CP.Arthook
{
public partial class ValoracionUsuarioCP : GenericBasicCP
{
public ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN New_ (float p_puntuacion, int p_emVal, int p_reVal)
{
        /*PROTECTED REGION ID(ArthookGen.ApplicationCore.CP.Arthook_ValoracionUsuario_new_) ENABLED START*/

        ValoracionUsuarioCEN valoracionUsuarioCEN = null;

        ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN result = null;


        try
        {
                CPSession.SessionInitializeTransaction ();
                valoracionUsuarioCEN = new  ValoracionUsuarioCEN (CPSession.UnitRepo.ValoracionUsuarioRepository);

                UsuarioCEN usuariocen = new UsuarioCEN (CPSession.UnitRepo.UsuarioRepository);
                UsuarioEN usuarioen = usuariocen.ReadOID (p_reVal);




                int oid;
                //Initialized ValoracionUsuarioEN
                ValoracionUsuarioEN valoracionUsuarioEN;
                valoracionUsuarioEN = new ValoracionUsuarioEN ();
                valoracionUsuarioEN.Puntuacion = p_puntuacion;


                if (p_emVal != -1) {
                        valoracionUsuarioEN.EmVal = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                        valoracionUsuarioEN.EmVal.Id = p_emVal;
                }


                if (p_reVal != -1) {
                        valoracionUsuarioEN.ReVal = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                        valoracionUsuarioEN.ReVal.Id = p_reVal;
                }




                oid = valoracionUsuarioCEN.get_IValoracionUsuarioRepository ().New_ (valoracionUsuarioEN);

                result = valoracionUsuarioCEN.get_IValoracionUsuarioRepository ().ReadOIDDefault (oid);

                IList<ValoracionUsuarioEN> valoraciones = valoracionUsuarioCEN.FiltrarXValoracion (p_reVal);
                float valm = 0;

                foreach (ValoracionUsuarioEN p in valoraciones) {
                        valm += p.Puntuacion;
                }

                valm = valm / valoraciones.Count;

                usuarioen.ValoracionMedia = valm;
                usuariocen.get_IUsuarioRepository ().ModifyDefault (usuarioen);


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
        return result;


        /*PROTECTED REGION END*/
}
}
}
