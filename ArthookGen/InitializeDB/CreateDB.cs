
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
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// VAMOS A CREAR LOS USUARIO //");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                /*creacion usuarios*/
                int usu1 = usuariocen.New_ (p_pass: "mry", p_nombre: "maria", p_email: "mgeg2@alu.ua.es", p_nickname: "mry2610", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.usuario);
                int usu2 = usuariocen.New_ (p_pass: "pep", p_nombre: "pepe", p_email: "pepeg2@alu.ua.es", p_nickname: "pepe3101", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.artista);
                int usu3 = usuariocen.New_ (p_pass: "ter", p_nombre: "teresa", p_email: "tgcg2@alu.ua.es", p_nickname: "ter2610", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.usuario);

                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");

                IList<UsuarioEN> listaUsuarios = usuariocen.ReadAll (0, 3);
                for (int i = 0; i < 3; i++) {
                        Console.WriteLine (listaUsuarios [i].Id.ToString () + " " + listaUsuarios [i].Nombre);
                }
                /*fin creacion usuarios*/
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");

                /*modificacion usuarios*/
                usuariocen.Modify (p_Usuario_OID: usu3, p_pass: "ter", p_nombre: "teresita", p_email: "tgcg2@alu.ua.es", p_nickname: "ter2610", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.usuario);
                IList<UsuarioEN> listaUsuariosm = usuariocen.ReadAll (0, 3);
                for (int i = 0; i < 3; i++) {
                        Console.WriteLine (listaUsuariosm [i].Nombre);
                }
                /* fin modificacion usuarios*/
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                /*destruccion usuarios*/
                usuariocen.Destroy (usu1);
                IList<UsuarioEN> listaUsuariosd = usuariocen.ReadAll (0, 2);
                for (int i = 0; i < 2; i++) {
                        Console.WriteLine (listaUsuariosd [i].Nombre);
                }
                /* fin destruccion usuarios*/
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                /*lectura un usuario*/
                UsuarioEN listaUsuariosr = usuariocen.ReadOID (usu2);

                Console.WriteLine (listaUsuariosr.Nombre);
                Console.WriteLine (listaUsuariosr.Pass);
                Console.WriteLine (listaUsuariosr.Email);
                /*fin lectura un usuario*/
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                /*Login*/
                if (usuariocen.Login (usu2, "mry") != null) {
                        Console.WriteLine ("Login Correcto");
                }
                /*fin de Login*/


                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// VAMOS A CREAR LOS PUBLIACIONES //");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");


                int publicacionId1 = publicacioncen.New_ (p_tipo: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum.imagen, p_descripcion: "esto es una foto no a la venta", p_titulo: "Foto1", p_tipoPublicacion: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum.Publicacion, p_usuarioPublicacion: usu2);;
                int publicacionId2 = publicacioncen.New_ (p_tipo: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum.imagen, p_descripcion: "esto es una foto a la venta", p_titulo: "Foto2", p_tipoPublicacion: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum.Producto, p_usuarioPublicacion: usu2);

                int publicacionId3 = publicacioncen.New_ (p_tipo: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum.audio, p_descripcion: "esto es una audio", p_titulo: "Audio1", p_tipoPublicacion: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum.Publicacion, p_usuarioPublicacion: usu3);
                int publicacionId4 = publicacioncen.New_ (p_tipo: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum.video, p_descripcion: "esto es una video", p_titulo: "Video1", p_tipoPublicacion: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum.Publicacion, p_usuarioPublicacion: usu3);

                int publicacionId5 = publicacioncen.New_ (p_tipo: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum.audio, p_descripcion: "esto es una audio", p_titulo: "Audio2", p_tipoPublicacion: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum.Publicacion, p_usuarioPublicacion: usu3);
                int publicacionId6 = publicacioncen.New_ (p_tipo: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum.video, p_descripcion: "esto es una video", p_titulo: "Video2", p_tipoPublicacion: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum.Publicacion, p_usuarioPublicacion: usu3);

                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                IList<PublicacionEN> listaPublicacion = publicacioncen.ReadAll (0, 6);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                Console.WriteLine ("MOSTRAMOS LAS PUBLICACIONES");
                foreach (PublicacionEN p in listaPublicacion) {
                        Console.WriteLine (p.Titulo + " " + p.Descripcion + " " + p.Tipo + " " + p.TipoPublicacion);
                }
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                publicacioncen.Modify (publicacionId1, p_tipo: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum.imagen, p_descripcion: "Esta descripccion a cambiado", p_titulo: "Foto1", p_tipoPublicacion: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum.Publicacion);
                PublicacionEN publicacionen = publicacioncen.ReadOID (publicacionId1);
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                Console.WriteLine (publicacionen.Descripcion);
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                publicacioncen.Destroy (publicacionId1);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                listaPublicacion = publicacioncen.ReadAll (0, 6);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                Console.WriteLine ("MOSTRAMOS LAS PUBLICACIONES");
                foreach (PublicacionEN p in listaPublicacion) {
                        Console.WriteLine (p.Titulo + " " + p.Descripcion + " " + p.Tipo + " " + p.TipoPublicacion);
                }
                Console.WriteLine ("");

                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// VAMOS A CREAR LOS VALORACIONES A PUBLICACIONES //");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");

                int valpub1 = valoracionpublicacioncen.New_ (p_puntuacion: 5, p_comentario: "esto es un comentario1", p_usuarioValoracion: usu2, p_publicacionValoracion: publicacionId2);
                int valpub2 = valoracionpublicacioncen.New_ (p_puntuacion: 4, p_comentario: "esto es un comentario2", p_usuarioValoracion: usu2, p_publicacionValoracion: publicacionId2);
                int valpub3 = valoracionpublicacioncen.New_ (p_puntuacion: 3, p_comentario: "esto es un comentario3", p_usuarioValoracion: usu2, p_publicacionValoracion: publicacionId2);
                int valpub4 = valoracionpublicacioncen.New_ (p_puntuacion: 2, p_comentario: "esto es un comentario4", p_usuarioValoracion: usu2, p_publicacionValoracion: publicacionId2);

                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                IList<ValoracionPublicacionEN> listaValoracionPublicacion = valoracionpublicacioncen.ReadAll (0, 4);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                Console.WriteLine ("MOSTRAMOS LAS VALORACIOENS");
                foreach (ValoracionPublicacionEN p in listaValoracionPublicacion) {
                        Console.WriteLine (p.Puntuacion + " " + p.Comentario);
                }
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                valoracionpublicacioncen.Modify (valpub1, p_puntuacion: 2, p_comentario: "este comentario cambia");
                ValoracionPublicacionEN valoracionpublicacionen = valoracionpublicacioncen.ReadOID (valpub1);
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                Console.WriteLine (valoracionpublicacionen.Puntuacion + " " + valoracionpublicacionen.Comentario);
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                valoracionpublicacioncen.Destroy (valpub1);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                listaValoracionPublicacion = valoracionpublicacioncen.ReadAll (0, 3);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                Console.WriteLine ("MOSTRAMOS LAS PUBLICACIONES");
                foreach (ValoracionPublicacionEN p in listaValoracionPublicacion) {
                        Console.WriteLine (p.Puntuacion + " " + p.Comentario);
                }
                Console.WriteLine ("");
                Console.WriteLine ("");
                Console.WriteLine ("");
                Console.WriteLine ("");



                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// VAMOS A CREAR LAS TARIFAS //");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");

                int tarifa1 = tarifacen.New_ (p_precio: 50, p_descripcion: "esto es una descripcion de una tarifa1", p_nombre: "tarifa 1", usu2);
                int tarifa2 = tarifacen.New_ (p_precio: 40, p_descripcion: "esto es una descripcion de una tarifa2", p_nombre: "tarifa 2", usu2);
                int tarifa3 = tarifacen.New_ (p_precio: 100, p_descripcion: "esto es una descripcion de una tarifa3", p_nombre: "tarifa 3", usu2);
                int tarifa4 = tarifacen.New_ (p_precio: 20, p_descripcion: "esto es una descripcion de una tarifa4", p_nombre: "tarifa 4", usu2);

                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                IList<TarifaEN> listaTarifas = tarifacen.ReadAll (0, 4);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                Console.WriteLine ("MOSTRAMOS LAS TARIFAS");
                foreach (TarifaEN p in listaTarifas) {
                        Console.WriteLine (p.Precio + " " + p.Descripcion + " " + p.Nombre);
                }
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                tarifacen.Modify (tarifa1, p_precio: 50, p_descripcion: "esta descripcion deberia cambiar", p_nombre: "tarifa 1");
                TarifaEN tarifaen = tarifacen.ReadOID (tarifa1);
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                Console.WriteLine (tarifaen.Precio + " " + tarifaen.Descripcion + " " + tarifaen.Nombre);
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                tarifacen.Destroy (tarifa1);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                listaTarifas = tarifacen.ReadAll (0, 3);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                Console.WriteLine ("MOSTRAMOS LAS TARIFAS");
                foreach (TarifaEN p in listaTarifas) {
                        Console.WriteLine (p.Precio + " " + p.Descripcion + " " + p.Nombre);
                }
                Console.WriteLine ("");

                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// VAMOS A CREAR PEDIDOS //");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");

                int pedido1 = pedidocen.New_ (p_fecha: DateTime.Now, p_precioTotal: 10, p_estado: ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum.enCarrito, p_usuarioPedido: usu2);
                int pedido2 = pedidocen.New_ (p_fecha: DateTime.Now, p_precioTotal: 20, p_estado: ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum.enviado, p_usuarioPedido: usu2);
                int pedido3 = pedidocen.New_ (p_fecha: DateTime.Now, p_precioTotal: 30, p_estado: ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum.pendiente, p_usuarioPedido: usu2);
                int pedido4 = pedidocen.New_ (p_fecha: DateTime.Now, p_precioTotal: 40, p_estado: ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum.devuelto, p_usuarioPedido: usu2);
                int pedido5 = pedidocen.New_ (p_fecha: DateTime.Now, p_precioTotal: 50, p_estado: ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum.cancelado, p_usuarioPedido: usu2);

                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                IList<PedidoEN> listaPedidos = pedidocen.ReadAll (0, 5);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                Console.WriteLine ("MOSTRAMOS LPOS PEDIDOS");
                foreach (PedidoEN p in listaPedidos) {
                        Console.WriteLine (p.Fecha + " " + p.PrecioTotal + " " + p.Estado);
                }
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                pedidocen.Modify (pedido1, p_fecha: pedidocen.ReadOID (pedido1).Fecha, p_precioTotal: 100, p_estado: ArthookGen.ApplicationCore.Enumerated.Arthook.EstadoEnum.enviado);
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                PedidoEN pedidoen = pedidocen.ReadOID (pedido1);
                Console.WriteLine (""); Console.WriteLine ("");
                Console.WriteLine (pedidoen.Fecha + " " + pedidoen.PrecioTotal + " " + pedidoen.Estado);
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                pedidocen.Destroy (pedido1);
                listaPedidos = pedidocen.ReadAll (0, 4);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                Console.WriteLine ("MOSTRAMOS LOS PEDIDOS");
                foreach (PedidoEN p in listaPedidos) {
                        Console.WriteLine (p.Fecha + " " + p.PrecioTotal + " " + p.Estado);
                }



                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// VAMOS A CREAR LINEAS DE PEDIDO //");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");

                int linped1 = linpedcen.New_ (p_cantidad: 1, p_precio: 10, p_pedidoLinPed: pedido2);
                int linped2 = linpedcen.New_ (p_cantidad: 2, p_precio: 20, p_pedidoLinPed: pedido2);
                int linped3 = linpedcen.New_ (p_cantidad: 3, p_precio: 30, p_pedidoLinPed: pedido2);
                int linped4 = linpedcen.New_ (p_cantidad: 4, p_precio: 40, p_pedidoLinPed: pedido2);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                IList<LinPedEN> listalineas = linpedcen.ReadAll (0, 4);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                Console.WriteLine ("MOSTRAMOS LPOS LINEAS DE PEDIDOS");
                foreach (LinPedEN p in listalineas) {
                        Console.WriteLine (p.Cantidad + " " + p.Precio);
                }
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                linpedcen.Modify (linped1, p_cantidad: 5, p_precio: 100);
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                LinPedEN lineaen = linpedcen.ReadOID (linped1);
                Console.WriteLine (""); Console.WriteLine ("");
                Console.WriteLine (lineaen.Cantidad + " " + lineaen.Precio);
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");
                linpedcen.Destroy (linped1);
                listalineas = linpedcen.ReadAll (0, 3);
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                Console.WriteLine ("MOSTRAMOS LAS LINEAS DE PEDIDOS");
                foreach (LinPedEN p in listalineas) {
                        Console.WriteLine (p.Cantidad + " " + p.Precio);
                }
                Console.WriteLine ("");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("// VAMOS A CREAR DEVOLUCION //");
                Console.WriteLine ("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine ("");

                int dev1 = devolucioncen.New_(p_descripcion: "esto me va fatal, quiero una devolucion1", p_motivo: ArthookGen.ApplicationCore.Enumerated.Arthook.MotivoEnum.malasCondciones, p_fecha: DateTime.Now, p_usuarioDevolucion: usu2, p_pedidoDevolucion: pedido2);
                int dev2 = devolucioncen.New_(p_descripcion: "esto me va fatal, quiero una devolucion2", p_motivo: ArthookGen.ApplicationCore.Enumerated.Arthook.MotivoEnum.malasCondciones, p_fecha: DateTime.Now, p_usuarioDevolucion: usu2, p_pedidoDevolucion: pedido3);
                int dev3 = devolucioncen.New_(p_descripcion: "esto me va fatal, quiero una devolucion3", p_motivo: ArthookGen.ApplicationCore.Enumerated.Arthook.MotivoEnum.noRecibido, p_fecha: DateTime.Now, p_usuarioDevolucion: usu2, p_pedidoDevolucion: pedido4);
                int dev4 = devolucioncen.New_(p_descripcion: "esto me va fatal, quiero una devolucion4", p_motivo: ArthookGen.ApplicationCore.Enumerated.Arthook.MotivoEnum.otros, p_fecha: DateTime.Now, p_usuarioDevolucion: usu2, p_pedidoDevolucion: pedido5);

                Console.WriteLine("// ---------------------------------------------------------------------------------------------------------------------------------//");
                IList<DevolucionEN> listadev = devolucioncen.ReadAll(0, 4);
                Console.WriteLine("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                Console.WriteLine("MOSTRAMOS LPOS LINEAS DE DEVOLUCIONES");
                foreach (DevolucionEN p in listadev)
                {
                    Console.WriteLine(p.Descripcion + " " + p.Fecha + " " + p.Motivo);
                }
                Console.WriteLine("");
                Console.WriteLine("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine("");
                devolucioncen.Modify(dev1, p_descripcion: "Esta descripcion cambia", p_motivo: ArthookGen.ApplicationCore.Enumerated.Arthook.MotivoEnum.noRecibido, p_fecha: DateTime.Now);
                Console.WriteLine("");
                Console.WriteLine("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine("");
                DevolucionEN deven = devolucioncen.ReadOID(dev1);
                Console.WriteLine(""); Console.WriteLine("");
                Console.WriteLine(deven.Descripcion + " " + deven.Fecha + " " + deven.Motivo);
                Console.WriteLine("");
                Console.WriteLine("// ---------------------------------------------------------------------------------------------------------------------------------//");
                Console.WriteLine("");
                devolucioncen.Destroy(dev1);
                listadev = devolucioncen.ReadAll(0, 4);
                Console.WriteLine("// ---------------------------------------------------------------------------------------------------------------------------------//\n");
                Console.WriteLine("MOSTRAMOS LPOS LINEAS DE PEDIDOS");
                foreach (DevolucionEN p in listadev)
                {
                    Console.WriteLine(p.Descripcion + " " + p.Fecha + " " + p.Motivo);
                }






                //              int publicacionId6 = publicacioncen.New_(p_tipo: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoProdEnum.video, p_descripcion: "esto es una video", p_titulo: "Video2", p_tipoPublicacion: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoPublicacionEnum.Publicacion, p_usuarioPublicacion: usu3);
                //              usuariocen.Modify(p_Usuario_OID: usu3, p_pass: "ter", p_nombre: "teresita", p_email: "tgcg2@alu.ua.es", p_nickname: "ter2610", p_tipoUsuario: ArthookGen.ApplicationCore.Enumerated.Arthook.TipoUsuarioEnum.usuario);
                //              usuariocen.Destroy(usu1);

                /*
                 * Console.WriteLine("");
                 * Console.WriteLine("// ---------------------------------------------------------------------------------------------------------------------------------//");
                 * Console.WriteLine("// ---------------------------------------------------------------------------------------------------------------------------------//");
                 * Console.WriteLine("// ---------------------------------------------------------------------------------------------------------------------------------//");
                 * Console.WriteLine("");
                 */

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
