
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using ArthookGen.ApplicationCore.CEN.Arthook;
using ArthookGen.ApplicationCore.CP.Arthook;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.Infraestructure.CP;
using ArthookGen.Infraestructure.Repository.Arthook;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

                /*creacion usuarios*/
                int usu1 = usuariocen.New_ (p_pass: "mry", p_nombre: "maria", p_email: "mgeg2@alu.ua.es", p_nickname: "mry2610", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.usuario);
                int usu2 = usuariocen.New_ (p_pass: "pep", p_nombre: "pepe", p_email: "pepeg2@alu.ua.es", p_nickname: "pepe3101", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.artista);
                int usu3 = usuariocen.New_ (p_pass: "ter", p_nombre: "teresa", p_email: "tgcg2@alu.ua.es", p_nickname: "ter2610", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.usuario);
                int usu4 = usuariocen.New_ (p_pass: "tera", p_nombre: "tereso", p_email: "tgcg2@alu.ua.es", p_nickname: "ter2610", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.usuario);
                int usu5 = usuariocen.New_ (p_pass: "terre", p_nombre: "terremoto", p_email: "tgcg2@alu.ua.es", p_nickname: "ter2610", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.usuario);
                IList<UsuarioEN> listaUsuarios = usuariocen.ReadAll (0, 5);
                for (int i = 0; i < 5; i++) {
                        Console.WriteLine (listaUsuarios [i].Nombre);
                }
                /*fin creacion usuarios*/

                /*modificacion usuarios*/
                usuariocen.Modify (p_Usuario_OID: usu3, p_pass: "ter", p_nombre: "teresita", p_email: "tgcg2@alu.ua.es", p_nickname: "ter2610", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.usuario);
                IList<UsuarioEN> listaUsuariosm = usuariocen.ReadAll (0, 3);
                for (int i = 0; i < 3; i++) {
                        Console.WriteLine (listaUsuariosm [i].Nombre);
                }
                /* fin modificacion usuarios*/

                /*destruccion usuarios*/
                usuariocen.Destroy (usu1);
                IList<UsuarioEN> listaUsuariosd = usuariocen.ReadAll (0, 2);
                for (int i = 0; i < 2; i++) {
                        Console.WriteLine (listaUsuariosd [i].Nombre);
                }
                /* fin destruccion usuarios*/

                /*lectura un usuario*/
                UsuarioEN listaUsuariosr = usuariocen.ReadOID (usu2);

                Console.WriteLine (listaUsuariosr.Nombre);
                Console.WriteLine (listaUsuariosr.Pass);
                Console.WriteLine (listaUsuariosr.Email);
                /*fin lectura un usuario*/

                /*Login*/
                if (usuariocen.Login (usu2, "mry") != null) {
                        Console.WriteLine ("Login Correcto");
                }
                /*fin de Login*/
                /*buscar por nombre*/
                IList<UsuarioEN> listaUNombre = usuariocen.BUsuarioporNick ("teresita");

                foreach (UsuarioEN user in listaUNombre) {
                        Console.WriteLine ("Nombre de usuario: " + user.Nombre);
                }
                /*fin buscar por nombre*/
                /* Crear mensaje*/
                int pub1 = publicacioncen.New_ (ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum.imagen, "imagen sobre paisajes indios", "taj mahal", ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum.Publicacion, usu3);
                /*fin crear mensaje*/
                /*filtrar por publicacion*/
                IList<PublicacionEN> listaPub = publicacioncen.FiltrarXUsuario (usu3);
                foreach (PublicacionEN user in listaPub) {
                        Console.WriteLine ("Nombre de usuario: " + user.Titulo);
                }
                /* fin filtrar por publicacion*/
                //UsuarioCP usuarioCP = new UsuarioCP (new SessionCPNHibernate ());

                /*filtrar por Valoracion en publicacion */


                int val1 = valoracionpublicacioncen.New_ ((float)5.00, "me gusta mucho", usu2, pub1);
                int val2 = valoracionpublicacioncen.New_ (4, "me gusta la india", usu2, pub1);
                int val3 = valoracionpublicacioncen.New_ (5, "me gusta mucho la india", usu2, pub1);
                IList<ValoracionPublicacionEN> listaval = valoracionpublicacioncen.FiltrarXvaloracion (pub1);
                foreach (ValoracionPublicacionEN user in listaval) {
                        Console.WriteLine ("Nombre de usuario: " + user.Comentario);
                }
                /* fin filtrar por Valoracion en publicacion*/
                /*filtrar por Valoracion en usuario */
                int val4 = valoracionusuariocen.New_ (5, usu3, usu2);
                  int val5 = valoracionusuariocen.New_ (4, usu4, usu2);
                  int val6 = valoracionusuariocen.New_ (5, usu5, usu2);
                  IList<ValoracionUsuarioEN> listavalU = valoracionusuariocen.FiltrarXValoracion (usu2);
                 foreach (ValoracionUsuarioEN valUser  in listavalU) {
                    Console.WriteLine ("con puntuacion : " + valUser.Puntuacion );
                 } 
                /* fin filtrar por Valoracion en usuario */
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
