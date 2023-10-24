
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
 * Clase ValoracionPublicacion:
 *
 */

namespace ArthookGen.Infraestructure.Repository.Arthook
{
public partial class ValoracionPublicacionRepository : BasicRepository, IValoracionPublicacionRepository
{
public ValoracionPublicacionRepository() : base ()
{
}


public ValoracionPublicacionRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ValoracionPublicacionEN ReadOIDDefault (int id
                                               )
{
        ValoracionPublicacionEN valoracionPublicacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionPublicacionEN = (ValoracionPublicacionEN)session.Get (typeof(ValoracionPublicacionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return valoracionPublicacionEN;
}

public System.Collections.Generic.IList<ValoracionPublicacionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ValoracionPublicacionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ValoracionPublicacionNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ValoracionPublicacionEN>();
                        else
                                result = session.CreateCriteria (typeof(ValoracionPublicacionNH)).List<ValoracionPublicacionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionPublicacionRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ValoracionPublicacionEN valoracionPublicacion)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionPublicacionNH valoracionPublicacionNH = (ValoracionPublicacionNH)session.Load (typeof(ValoracionPublicacionNH), valoracionPublicacion.Id);

                valoracionPublicacionNH.Puntuacion = valoracionPublicacion.Puntuacion;


                valoracionPublicacionNH.Comentario = valoracionPublicacion.Comentario;



                session.Update (valoracionPublicacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionPublicacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ValoracionPublicacionEN valoracionPublicacion)
{
        ValoracionPublicacionNH valoracionPublicacionNH = new ValoracionPublicacionNH (valoracionPublicacion);

        try
        {
                SessionInitializeTransaction ();
                if (valoracionPublicacion.Publicacion != null) {
                        // Argumento OID y no colección.
                        valoracionPublicacionNH
                        .Publicacion = (ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN), valoracionPublicacion.Publicacion.Id);

                        valoracionPublicacionNH.Publicacion.Valoracion
                        .Add (valoracionPublicacionNH);
                }
                if (valoracionPublicacion.Usuario != null) {
                        // Argumento OID y no colección.
                        valoracionPublicacionNH
                        .Usuario = (ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN), valoracionPublicacion.Usuario.Id);

                        valoracionPublicacionNH.Usuario.Valoracion
                        .Add (valoracionPublicacionNH);
                }

                session.Save (valoracionPublicacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionPublicacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionPublicacionNH.Id;
}

public void Modify (ValoracionPublicacionEN valoracionPublicacion)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionPublicacionNH valoracionPublicacionNH = (ValoracionPublicacionNH)session.Load (typeof(ValoracionPublicacionNH), valoracionPublicacion.Id);

                valoracionPublicacionNH.Puntuacion = valoracionPublicacion.Puntuacion;


                valoracionPublicacionNH.Comentario = valoracionPublicacion.Comentario;

                session.Update (valoracionPublicacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionPublicacionRepository.", ex);
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
                ValoracionPublicacionNH valoracionPublicacionNH = (ValoracionPublicacionNH)session.Load (typeof(ValoracionPublicacionNH), id);
                session.Delete (valoracionPublicacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionPublicacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ValoracionPublicacionEN
public ValoracionPublicacionEN ReadOID (int id
                                        )
{
        ValoracionPublicacionEN valoracionPublicacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionPublicacionEN = (ValoracionPublicacionEN)session.Get (typeof(ValoracionPublicacionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return valoracionPublicacionEN;
}

public System.Collections.Generic.IList<ValoracionPublicacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ValoracionPublicacionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ValoracionPublicacionNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<ValoracionPublicacionEN>();
                else
                        result = session.CreateCriteria (typeof(ValoracionPublicacionNH)).List<ValoracionPublicacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionPublicacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
