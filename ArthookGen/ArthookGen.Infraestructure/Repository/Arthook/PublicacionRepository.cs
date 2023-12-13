
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


                publicacionNH.Titulo = publicacion.Titulo;


                publicacionNH.TipoPublicacion = publicacion.TipoPublicacion;





                publicacionNH.Imagen = publicacion.Imagen;

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
                if (publicacion.UsuarioPublicacion != null) {
                        // Argumento OID y no colección.
                        publicacionNH
                        .UsuarioPublicacion = (ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN), publicacion.UsuarioPublicacion.Id);

                        publicacionNH.UsuarioPublicacion.PublicacionUsuario
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


                publicacionNH.Titulo = publicacion.Titulo;


                publicacionNH.TipoPublicacion = publicacion.TipoPublicacion;


                publicacionNH.Imagen = publicacion.Imagen;

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

public System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> FiltrarXUsuario (int ? id)
{
        System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PublicacionNH self where Select pub FROM PublicacionNH as pub where pub.UsuarioPublicacion=:id";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PublicacionNHFiltrarXUsuarioHQL");
                query.SetParameter ("id", id);

                result = query.List<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN>();
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
