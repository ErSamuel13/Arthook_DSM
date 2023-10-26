
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
 * Clase Tarifa:
 *
 */

namespace ArthookGen.Infraestructure.Repository.Arthook
{
public partial class TarifaRepository : BasicRepository, ITarifaRepository
{
public TarifaRepository() : base ()
{
}


public TarifaRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public TarifaEN ReadOIDDefault (int id
                                )
{
        TarifaEN tarifaEN = null;

        try
        {
                SessionInitializeTransaction ();
                tarifaEN = (TarifaEN)session.Get (typeof(TarifaNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return tarifaEN;
}

public System.Collections.Generic.IList<TarifaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<TarifaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TarifaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<TarifaEN>();
                        else
                                result = session.CreateCriteria (typeof(TarifaNH)).List<TarifaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in TarifaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (TarifaEN tarifa)
{
        try
        {
                SessionInitializeTransaction ();
                TarifaNH tarifaNH = (TarifaNH)session.Load (typeof(TarifaNH), tarifa.Id);

                tarifaNH.Precio = tarifa.Precio;


                tarifaNH.Descripcion = tarifa.Descripcion;


                tarifaNH.Nombre = tarifa.Nombre;


                session.Update (tarifaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in TarifaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (TarifaEN tarifa)
{
        TarifaNH tarifaNH = new TarifaNH (tarifa);

        try
        {
                SessionInitializeTransaction ();
                if (tarifa.UsuarioTarifa != null) {
                        // Argumento OID y no colección.
                        tarifaNH
                        .UsuarioTarifa = (ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN), tarifa.UsuarioTarifa.Id);

                        tarifaNH.UsuarioTarifa.Tarifa
                        .Add (tarifaNH);
                }

                session.Save (tarifaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in TarifaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tarifaNH.Id;
}

public void Modify (TarifaEN tarifa)
{
        try
        {
                SessionInitializeTransaction ();
                TarifaNH tarifaNH = (TarifaNH)session.Load (typeof(TarifaNH), tarifa.Id);

                tarifaNH.Precio = tarifa.Precio;


                tarifaNH.Descripcion = tarifa.Descripcion;


                tarifaNH.Nombre = tarifa.Nombre;

                session.Update (tarifaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in TarifaRepository.", ex);
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
                TarifaNH tarifaNH = (TarifaNH)session.Load (typeof(TarifaNH), id);
                session.Delete (tarifaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in TarifaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: TarifaEN
public TarifaEN ReadOID (int id
                         )
{
        TarifaEN tarifaEN = null;

        try
        {
                SessionInitializeTransaction ();
                tarifaEN = (TarifaEN)session.Get (typeof(TarifaNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return tarifaEN;
}

public System.Collections.Generic.IList<TarifaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TarifaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(TarifaNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<TarifaEN>();
                else
                        result = session.CreateCriteria (typeof(TarifaNH)).List<TarifaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in TarifaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
