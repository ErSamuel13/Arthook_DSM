
using System;
using System.Text;
using ArthookGen.ApplicationCore.CEN.Arthook;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.Exceptions;
using ArthookGen.ApplicationCore.IRepository.Arthook;
using ArthookGen.ApplicationCore.CP.Arthook;
using ArthookGen.Infraestructure.EN.Arthook;


/*
 * Clase Devolucion:
 *
 */

namespace ArthookGen.Infraestructure.Repository.Arthook
{
public partial class DevolucionRepository : BasicRepository, IDevolucionRepository
{
public DevolucionRepository() : base ()
{
}


public DevolucionRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public DevolucionEN ReadOIDDefault (int id
                                    )
{
        DevolucionEN devolucionEN = null;

        try
        {
                SessionInitializeTransaction ();
                devolucionEN = (DevolucionEN)session.Get (typeof(DevolucionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return devolucionEN;
}

public System.Collections.Generic.IList<DevolucionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DevolucionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DevolucionNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<DevolucionEN>();
                        else
                                result = session.CreateCriteria (typeof(DevolucionNH)).List<DevolucionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in DevolucionRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DevolucionEN devolucion)
{
        try
        {
                SessionInitializeTransaction ();
                DevolucionNH devolucionNH = (DevolucionNH)session.Load (typeof(DevolucionNH), devolucion.Id);

                devolucionNH.Descripcion = devolucion.Descripcion;


                devolucionNH.Motivo = devolucion.Motivo;


                devolucionNH.Fecha = devolucion.Fecha;



                session.Update (devolucionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in DevolucionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (DevolucionEN devolucion)
{
        DevolucionNH devolucionNH = new DevolucionNH (devolucion);

        try
        {
                SessionInitializeTransaction ();
                if (devolucion.UsuarioDevolucion != null) {
                        // Argumento OID y no colección.
                        devolucionNH
                        .UsuarioDevolucion = (ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN), devolucion.UsuarioDevolucion.Id);

                        devolucionNH.UsuarioDevolucion.DevolucionUsuario
                        .Add (devolucionNH);
                }
                if (devolucion.PedidoDevolucion != null) {
                        // Argumento OID y no colección.
                        devolucionNH
                        .PedidoDevolucion = (ArthookGen.ApplicationCore.EN.Arthook.PedidoEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.PedidoEN), devolucion.PedidoDevolucion.Id);

                        devolucionNH.PedidoDevolucion.DevolucionPedido
                                = devolucionNH;
                }

                session.Save (devolucionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in DevolucionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return devolucionNH.Id;
}

public void Modify (DevolucionEN devolucion)
{
        try
        {
                SessionInitializeTransaction ();
                DevolucionNH devolucionNH = (DevolucionNH)session.Load (typeof(DevolucionNH), devolucion.Id);

                devolucionNH.Descripcion = devolucion.Descripcion;


                devolucionNH.Motivo = devolucion.Motivo;


                devolucionNH.Fecha = devolucion.Fecha;

                session.Update (devolucionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in DevolucionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                DevolucionNH devolucionNH = (DevolucionNH)session.Load (typeof(DevolucionNH), id);
                session.Delete (devolucionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in DevolucionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: DevolucionEN
public DevolucionEN ReadOID (int id
                             )
{
        DevolucionEN devolucionEN = null;

        try
        {
                SessionInitializeTransaction ();
                devolucionEN = (DevolucionEN)session.Get (typeof(DevolucionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return devolucionEN;
}

public System.Collections.Generic.IList<DevolucionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DevolucionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DevolucionNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<DevolucionEN>();
                else
                        result = session.CreateCriteria (typeof(DevolucionNH)).List<DevolucionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in DevolucionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
