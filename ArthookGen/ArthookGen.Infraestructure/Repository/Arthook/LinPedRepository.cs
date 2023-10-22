
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
 * Clase LinPed:
 *
 */

namespace ArthookGen.Infraestructure.Repository.Arthook
{
public partial class LinPedRepository : BasicRepository, ILinPedRepository
{
public LinPedRepository() : base ()
{
}


public LinPedRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public LinPedEN ReadOIDDefault (int id
                                )
{
        LinPedEN linPedEN = null;

        try
        {
                SessionInitializeTransaction ();
                linPedEN = (LinPedEN)session.Get (typeof(LinPedNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return linPedEN;
}

public System.Collections.Generic.IList<LinPedEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<LinPedEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(LinPedNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<LinPedEN>();
                        else
                                result = session.CreateCriteria (typeof(LinPedNH)).List<LinPedEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in LinPedRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (LinPedEN linPed)
{
        try
        {
                SessionInitializeTransaction ();
                LinPedNH linPedNH = (LinPedNH)session.Load (typeof(LinPedNH), linPed.Id);

                linPedNH.Cantidad = linPed.Cantidad;


                linPedNH.Precio = linPed.Precio;



                session.Update (linPedNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in LinPedRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (LinPedEN linPed)
{
        LinPedNH linPedNH = new LinPedNH (linPed);

        try
        {
                SessionInitializeTransaction ();
                if (linPed.Publicacion != null) {
                        // Argumento OID y no colección.
                        linPedNH
                        .Publicacion = (ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN), linPed.Publicacion.Id);

                        linPedNH.Publicacion.LinPed
                                = linPedNH;
                }
                if (linPed.Pedido != null) {
                        // Argumento OID y no colección.
                        linPedNH
                        .Pedido = (ArthookGen.ApplicationCore.EN.Arthook.PedidoEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.PedidoEN), linPed.Pedido.Id);

                        linPedNH.Pedido.LinPed
                        .Add (linPedNH);
                }

                session.Save (linPedNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in LinPedRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return linPedNH.Id;
}

public void Modify (LinPedEN linPed)
{
        try
        {
                SessionInitializeTransaction ();
                LinPedNH linPedNH = (LinPedNH)session.Load (typeof(LinPedNH), linPed.Id);

                linPedNH.Cantidad = linPed.Cantidad;


                linPedNH.Precio = linPed.Precio;

                session.Update (linPedNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in LinPedRepository.", ex);
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
                LinPedNH linPedNH = (LinPedNH)session.Load (typeof(LinPedNH), id);
                session.Delete (linPedNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in LinPedRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: LinPedEN
public LinPedEN ReadOID (int id
                         )
{
        LinPedEN linPedEN = null;

        try
        {
                SessionInitializeTransaction ();
                linPedEN = (LinPedEN)session.Get (typeof(LinPedNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return linPedEN;
}

public System.Collections.Generic.IList<LinPedEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<LinPedEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(LinPedNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<LinPedEN>();
                else
                        result = session.CreateCriteria (typeof(LinPedNH)).List<LinPedEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in LinPedRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
