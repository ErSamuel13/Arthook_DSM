<<<<<<< HEAD

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
 * Clase ValoracionUsuario:
 *
 */

namespace ArthookGen.Infraestructure.Repository.Arthook
{
public partial class ValoracionUsuarioRepository : BasicRepository, IValoracionUsuarioRepository
{
public ValoracionUsuarioRepository() : base ()
{
}


public ValoracionUsuarioRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ValoracionUsuarioEN ReadOIDDefault (int id
                                           )
{
        ValoracionUsuarioEN valoracionUsuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionUsuarioEN = (ValoracionUsuarioEN)session.Get (typeof(ValoracionUsuarioNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return valoracionUsuarioEN;
}

public System.Collections.Generic.IList<ValoracionUsuarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ValoracionUsuarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ValoracionUsuarioNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ValoracionUsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(ValoracionUsuarioNH)).List<ValoracionUsuarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionUsuarioRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ValoracionUsuarioEN valoracionUsuario)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionUsuarioNH valoracionUsuarioNH = (ValoracionUsuarioNH)session.Load (typeof(ValoracionUsuarioNH), valoracionUsuario.Id);

                valoracionUsuarioNH.Puntuacion = valoracionUsuario.Puntuacion;



                session.Update (valoracionUsuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionUsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ValoracionUsuarioEN valoracionUsuario)
{
        ValoracionUsuarioNH valoracionUsuarioNH = new ValoracionUsuarioNH (valoracionUsuario);

        try
        {
                SessionInitializeTransaction ();

                session.Save (valoracionUsuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionUsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionUsuarioNH.Id;
}

public void Modify (ValoracionUsuarioEN valoracionUsuario)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionUsuarioNH valoracionUsuarioNH = (ValoracionUsuarioNH)session.Load (typeof(ValoracionUsuarioNH), valoracionUsuario.Id);

                valoracionUsuarioNH.Puntuacion = valoracionUsuario.Puntuacion;

                session.Update (valoracionUsuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionUsuarioRepository.", ex);
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
                ValoracionUsuarioNH valoracionUsuarioNH = (ValoracionUsuarioNH)session.Load (typeof(ValoracionUsuarioNH), id);
                session.Delete (valoracionUsuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionUsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ValoracionUsuarioEN
public ValoracionUsuarioEN ReadOID (int id
                                    )
{
        ValoracionUsuarioEN valoracionUsuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionUsuarioEN = (ValoracionUsuarioEN)session.Get (typeof(ValoracionUsuarioNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return valoracionUsuarioEN;
}

public System.Collections.Generic.IList<ValoracionUsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ValoracionUsuarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ValoracionUsuarioNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<ValoracionUsuarioEN>();
                else
                        result = session.CreateCriteria (typeof(ValoracionUsuarioNH)).List<ValoracionUsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionUsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
=======

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
 * Clase ValoracionUsuario:
 *
 */

namespace ArthookGen.Infraestructure.Repository.Arthook
{
public partial class ValoracionUsuarioRepository : BasicRepository, IValoracionUsuarioRepository
{
public ValoracionUsuarioRepository() : base ()
{
}


public ValoracionUsuarioRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ValoracionUsuarioEN ReadOIDDefault (int id
                                           )
{
        ValoracionUsuarioEN valoracionUsuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionUsuarioEN = (ValoracionUsuarioEN)session.Get (typeof(ValoracionUsuarioNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return valoracionUsuarioEN;
}

public System.Collections.Generic.IList<ValoracionUsuarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ValoracionUsuarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ValoracionUsuarioNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ValoracionUsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(ValoracionUsuarioNH)).List<ValoracionUsuarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionUsuarioRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ValoracionUsuarioEN valoracionUsuario)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionUsuarioNH valoracionUsuarioNH = (ValoracionUsuarioNH)session.Load (typeof(ValoracionUsuarioNH), valoracionUsuario.Id);

                valoracionUsuarioNH.Puntuacion = valoracionUsuario.Puntuacion;



                session.Update (valoracionUsuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionUsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ValoracionUsuarioEN valoracionUsuario)
{
        ValoracionUsuarioNH valoracionUsuarioNH = new ValoracionUsuarioNH (valoracionUsuario);

        try
        {
                SessionInitializeTransaction ();
                if (valoracionUsuario.EmVal != null) {
                        // Argumento OID y no colección.
                        valoracionUsuarioNH
                        .EmVal = (ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN), valoracionUsuario.EmVal.Id);

                        valoracionUsuarioNH.EmVal.ValoracionEmitida
                        .Add (valoracionUsuarioNH);
                }
                if (valoracionUsuario.ReVal != null) {
                        // Argumento OID y no colección.
                        valoracionUsuarioNH
                        .ReVal = (ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN)session.Load (typeof(ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN), valoracionUsuario.ReVal.Id);

                        valoracionUsuarioNH.ReVal.ValoracionRecibida
                        .Add (valoracionUsuarioNH);
                }

                session.Save (valoracionUsuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionUsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionUsuarioNH.Id;
}

public void Modify (ValoracionUsuarioEN valoracionUsuario)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionUsuarioNH valoracionUsuarioNH = (ValoracionUsuarioNH)session.Load (typeof(ValoracionUsuarioNH), valoracionUsuario.Id);

                valoracionUsuarioNH.Puntuacion = valoracionUsuario.Puntuacion;

                session.Update (valoracionUsuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionUsuarioRepository.", ex);
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
                ValoracionUsuarioNH valoracionUsuarioNH = (ValoracionUsuarioNH)session.Load (typeof(ValoracionUsuarioNH), id);
                session.Delete (valoracionUsuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionUsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ValoracionUsuarioEN
public ValoracionUsuarioEN ReadOID (int id
                                    )
{
        ValoracionUsuarioEN valoracionUsuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionUsuarioEN = (ValoracionUsuarioEN)session.Get (typeof(ValoracionUsuarioNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return valoracionUsuarioEN;
}

public System.Collections.Generic.IList<ValoracionUsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ValoracionUsuarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ValoracionUsuarioNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<ValoracionUsuarioEN>();
                else
                        result = session.CreateCriteria (typeof(ValoracionUsuarioNH)).List<ValoracionUsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionUsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> FiltrarXValoracion (int ? idUsu)
{
        System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ValoracionUsuarioNH self where select valU FROM ValoracionUsuarioNH  as valU inner join valU.ReVal as val where val.Id=:idUsu";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ValoracionUsuarioNHFiltrarXValoracionHQL");
                query.SetParameter ("idUsu", idUsu);

                result = query.List<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ArthookGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new ArthookGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionUsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
>>>>>>> Developer
