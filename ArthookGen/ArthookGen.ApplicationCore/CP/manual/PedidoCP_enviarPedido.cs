
using System;
using System.Text;

using System.Collections.Generic;
using ArthookGen.ApplicationCore.Exceptions;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;
using ArthookGen.ApplicationCore.CEN.Arthook;



/*PROTECTED REGION ID(usingArthookGen.ApplicationCore.CP.Arthook_Pedido_enviarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ArthookGen.ApplicationCore.CP.Arthook
{
public partial class PedidoCP : GenericBasicCP
{
public void EnviarPedido (int p_oid)
{
        /*PROTECTED REGION ID(ArthookGen.ApplicationCore.CP.Arthook_Pedido_enviarPedido) ENABLED START*/

        PedidoCEN pedidoCEN = null;



        try
        {
                CPSession.SessionInitializeTransaction ();
                pedidoCEN = new  PedidoCEN (CPSession.UnitRepo.PedidoRepository);


                PedidoEN pedidoEN = pedidoCEN.ReadOID (p_oid);
                if (!(pedidoEN.Estado == Enumerated.Arthook.EstadoEnum.pendiente))
                        throw new ModelException ("El pedido tiene que estar pendiente para poder enviarse");



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
