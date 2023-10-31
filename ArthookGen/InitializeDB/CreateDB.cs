
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.CEN.Arthook;
using ArthookGen.Infraestructure.Repository.Arthook;
using ArthookGen.Infraestructure.CP;
using ArthookGen.ApplicationCore.Exceptions;

using ArthookGen.ApplicationCore.CP.Arthook;
using ArthookGen.Infraestructure.Repository;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception)
        {
                throw;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        try
        {
                // Initialising  CENs
                PublicacionRepository publicacionrepository = new PublicacionRepository ();
                PublicacionCEN publicacioncen = new PublicacionCEN (publicacionrepository);
                PedidoRepository pedidorepository = new PedidoRepository ();
                PedidoCEN pedidocen = new PedidoCEN (pedidorepository);
                LinPedRepository linpedrepository = new LinPedRepository ();
                LinPedCEN linpedcen = new LinPedCEN (linpedrepository);
                MensajeRepository mensajerepository = new MensajeRepository ();
                MensajeCEN mensajecen = new MensajeCEN (mensajerepository);
                ValoracionUsuarioRepository valoracionusuariorepository = new ValoracionUsuarioRepository ();
                ValoracionUsuarioCEN valoracionusuariocen = new ValoracionUsuarioCEN (valoracionusuariorepository);
                ValoracionPublicacionRepository valoracionpublicacionrepository = new ValoracionPublicacionRepository ();
                ValoracionPublicacionCEN valoracionpublicacioncen = new ValoracionPublicacionCEN (valoracionpublicacionrepository);
                DevolucionRepository devolucionrepository = new DevolucionRepository ();
                DevolucionCEN devolucioncen = new DevolucionCEN (devolucionrepository);
                TarifaRepository tarifarepository = new TarifaRepository ();
                TarifaCEN tarifacen = new TarifaCEN (tarifarepository);
                UsuarioRepository usuariorepository = new UsuarioRepository ();
                UsuarioCEN usuariocen = new UsuarioCEN (usuariorepository);
                MetodoPagoRepository metodopagorepository = new MetodoPagoRepository ();
                MetodoPagoCEN metodopagocen = new MetodoPagoCEN (metodopagorepository);



                /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/

                 int usu1 = usuariocen.New_ (p_pass: "mry", p_nombre: "maria", p_email: "mgeg2@alu.ua.es", p_nickname: "mry2610", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.usuario);
                 int usu2 = usuariocen.New_(p_pass: "pep", p_nombre: "pepe", p_email: "pepeg2@alu.ua.es", p_nickname: "pepe3101", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.artista);
                 int usu3 = usuariocen.New_(p_pass: "ter", p_nombre: "teresa", p_email: "tgcg2@alu.ua.es", p_nickname: "ter2610", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.usuario);
                IList<UsuarioEN> listaUsuarios = usuariocen.ReadAll(0,3);
                Console.WriteLine ("se han creado todos los usuarios");
                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw;
        }
}
}
}
