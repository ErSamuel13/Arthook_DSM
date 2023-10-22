
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
 * Clase Publicacion:
 *
 */

namespace ArthookGen.Infraestructure.Repository.Arthook
{
public partial class PublicacionRepository : BasicRepository, IPublicacionRepository
{
public PublicacionRepository() : base ()
{
}


public PublicacionRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public PublicacionEN ReadOIDDefault (int id
                                     )
{
        PublicacionEN publicacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                publicacionEN = (PublicacionEN)session.Get (typeof(PublicacionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return publicacionEN;
}

public System.Collections.Generic.IList<PublicacionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PublicacionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PublicacionNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<PublicacionEN>();
                        else
                                result = session.CreateCriteria (typeof(PublicacionNH)).List<PublicacionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in PublicacionRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PublicacionEN publicacion)
{
        try
        {
                SessionInitializeTransaction ();
                PublicacionNH publicacionNH = (PublicacionNH)session.Load (typeof(PublicacionNH), publicacion.Id);

                publicacionNH.Pvp = publicacion.Pvp;


                publicacionNH.Tipo = publicacion.Tipo;


                publicacionNH.Descripcion = publicacion.Descripcion;


                publicacionNH.ValoracionMedia = publicacion.ValoracionMedia;


                publicacionNH.Titulo = publicacion.Titulo;


                publicacionNH.TipoPubli = publicacion.TipoPubli;




                session.Update (publicacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in PublicacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PublicacionEN publicacion)
{
        PublicacionNH publicacionNH = new PublicacionNH (publicacion);

        try
        {
                SessionInitializeTransaction ();
                if (publicacion.Valoracion != null) {
                        // Argumento OID y no colección.
                        publicacionNH
                        .Valoracion = (ArthookGen.ApplicationCore.EN.Arthook.ValoracionEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.ValoracionEN), publicacion.Valoracion.Id);

                        publicacionNH.Valoracion.Publicacion
                        .Add (publicacionNH);
                }

                session.Save (publicacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in PublicacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return publicacionNH.Id;
}

public void Modify (PublicacionEN publicacion)
{
        try
        {
                SessionInitializeTransaction ();
                PublicacionNH publicacionNH = (PublicacionNH)session.Load (typeof(PublicacionNH), publicacion.Id);

                publicacionNH.Tipo = publicacion.Tipo;


                publicacionNH.Descripcion = publicacion.Descripcion;


                publicacionNH.ValoracionMedia = publicacion.ValoracionMedia;


                publicacionNH.Titulo = publicacion.Titulo;

                session.Update (publicacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in PublicacionRepository.", ex);
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
                PublicacionNH publicacionNH = (PublicacionNH)session.Load (typeof(PublicacionNH), id);
                session.Delete (publicacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in PublicacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PublicacionEN
public PublicacionEN ReadOID (int id
                              )
{
        PublicacionEN publicacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                publicacionEN = (PublicacionEN)session.Get (typeof(PublicacionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return publicacionEN;
}

public System.Collections.Generic.IList<PublicacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PublicacionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PublicacionNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<PublicacionEN>();
                else
                        result = session.CreateCriteria (typeof(PublicacionNH)).List<PublicacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in PublicacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
