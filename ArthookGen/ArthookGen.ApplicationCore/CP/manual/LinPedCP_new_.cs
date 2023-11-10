
using System;
using System.Text;

using System.Collections.Generic;
using ArthookGen.ApplicationCore.Exceptions;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;
using ArthookGen.ApplicationCore.CEN.Arthook;



/*PROTECTED REGION ID(usingArthookGen.ApplicationCore.CP.Arthook_LinPed_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ArthookGen.ApplicationCore.CP.Arthook
{
public partial class LinPedCP : GenericBasicCP
{
public ArthookGen.ApplicationCore.EN.Arthook.LinPedEN New_ (int p_cantidad, int p_pedidoLinPed, int p_publicacionLinPed)
{
        /*PROTECTED REGION ID(ArthookGen.ApplicationCore.CP.Arthook_LinPed_new_) ENABLED START*/

        LinPedCEN linPedCEN = null;

        ArthookGen.ApplicationCore.EN.Arthook.LinPedEN result = null;


        try
        {
                CPSession.SessionInitializeTransaction ();
                linPedCEN = new  LinPedCEN (CPSession.UnitRepo.LinPedRepository);
                PublicacionCEN publicacionCEN = new PublicacionCEN (CPSession.UnitRepo.PublicacionRepository);
                PublicacionEN publicacionEN = publicacionCEN.ReadOID (p_publicacionLinPed);
                PedidoCEN pedidoCEN = new PedidoCEN (CPSession.UnitRepo.PedidoRepository);
                PedidoEN pedidoEN = pedidoCEN.ReadOID (p_pedidoLinPed);

                int oid;
                //Initialized LinPedEN
                LinPedEN linPedEN;
                linPedEN = new LinPedEN ();
                linPedEN.Cantidad = p_cantidad;

                linPedEN.PrecioT = publicacionEN.Pvp * p_cantidad;


                if (p_pedidoLinPed != -1) {
                        linPedEN.PedidoLinPed = new ArthookGen.ApplicationCore.EN.Arthook.PedidoEN ();
                        linPedEN.PedidoLinPed.Id = p_pedidoLinPed;
                }

                pedidoEN.PrecioTotal += linPedEN.PrecioT;
                pedidoCEN.get_IPedidoRepository ().ModifyDefault (pedidoEN);

                oid = linPedCEN.get_ILinPedRepository ().New_ (linPedEN);

                result = linPedCEN.get_ILinPedRepository ().ReadOIDDefault (oid);



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
