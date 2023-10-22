
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
 * Clase Usuario:
 *
 */

namespace ArthookGen.Infraestructure.Repository.Arthook
{
public partial class UsuarioRepository : BasicRepository, IUsuarioRepository
{
public UsuarioRepository() : base ()
{
}


public UsuarioRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public UsuarioEN ReadOIDDefault (int id
                                 )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioNH)).List<UsuarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioNH usuarioNH = (UsuarioNH)session.Load (typeof(UsuarioNH), usuario.Id);

                usuarioNH.Nombre = usuario.Nombre;


                usuarioNH.Email = usuario.Email;


                usuarioNH.Nickname = usuario.Nickname;


                usuarioNH.Password = usuario.Password;


                usuarioNH.Telefono = usuario.Telefono;








                usuarioNH.Valoracion = usuario.Valoracion;


                session.Update (usuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (UsuarioEN usuario)
{
        UsuarioNH usuarioNH = new UsuarioNH (usuario);

        try
        {
                SessionInitializeTransaction ();
                if (usuario.MensajeE != null) {
                        for (int i = 0; i < usuario.MensajeE.Count; i++) {
                                usuario.MensajeE [i] = (ArthookGen.ApplicationCore.EN.Arthook.MensajeEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.MensajeEN), usuario.MensajeE [i].Id);
                                usuario.MensajeE [i].Emisor.Add (usuarioNH);
                        }
                }
                if (usuario.MensajeR != null) {
                        for (int i = 0; i < usuario.MensajeR.Count; i++) {
                                usuario.MensajeR [i] = (ArthookGen.ApplicationCore.EN.Arthook.MensajeEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.MensajeEN), usuario.MensajeR [i].Id);
                                usuario.MensajeR [i].Receptor.Add (usuarioNH);
                        }
                }
                if (usuario.Publicacion != null) {
                        // Argumento OID y no colección.
                        usuarioNH
                        .Publicacion = (ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN), usuario.Publicacion.Id);

                        usuarioNH.Publicacion.Usuario
                        .Add (usuarioNH);
                }
                if (usuario.Tarifa != null) {
                        // Argumento OID y no colección.
                        usuarioNH
                        .Tarifa = (ArthookGen.ApplicationCore.EN.Arthook.TarifaEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.TarifaEN), usuario.Tarifa.Id);

                        usuarioNH.Tarifa.Usuario
                        .Add (usuarioNH);
                }
                if (usuario.Valoracion != null) {
                        // Argumento OID y no colección.
                        usuarioNH
                        .Valoracion = (ArthookGen.ApplicationCore.EN.Arthook.ValoracionEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.ValoracionEN), usuario.Valoracion.Id);

                        usuarioNH.Valoracion.Usuario
                        .Add (usuarioNH);
                }

                session.Save (usuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioNH.Id;
}

public void Modify (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioNH usuarioNH = (UsuarioNH)session.Load (typeof(UsuarioNH), usuario.Id);

                usuarioNH.Nombre = usuario.Nombre;


                usuarioNH.Email = usuario.Email;


                usuarioNH.Nickname = usuario.Nickname;


                usuarioNH.Password = usuario.Password;


                usuarioNH.Telefono = usuario.Telefono;

                session.Update (usuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
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
                UsuarioNH usuarioNH = (UsuarioNH)session.Load (typeof(UsuarioNH), id);
                session.Delete (usuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: UsuarioEN
public UsuarioEN ReadOID (int id
                          )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(UsuarioNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                else
                        result = session.CreateCriteria (typeof(UsuarioNH)).List<UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
