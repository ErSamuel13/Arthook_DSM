

using System;
using System.Text;
using System.Collections.Generic;

using ArthookGen.ApplicationCore.Exceptions;

using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;


namespace ArthookGen.ApplicationCore.CEN.Arthook
{
/*
 *      Definition of the class LinPedCEN
 *
 */
public partial class LinPedCEN
{
private ILinPedRepository _ILinPedRepository;

public LinPedCEN(ILinPedRepository _ILinPedRepository)
{
        this._ILinPedRepository = _ILinPedRepository;
}

public ILinPedRepository get_ILinPedRepository ()
{
        return this._ILinPedRepository;
}

public int New_ (int p_Cantidad, float p_precio, int p_pedido, int p_publicacion)
{
        LinPedEN linPedEN = null;
        int oid;

        //Initialized LinPedEN
        linPedEN = new LinPedEN ();
        linPedEN.Cantidad = p_Cantidad;

        linPedEN.Precio = p_precio;


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                linPedEN.Pedido = new ArthookGen.ApplicationCore.EN.Arthook.PedidoEN ();
                linPedEN.Pedido.Id = p_pedido;
        }


        if (p_publicacion != -1) {
                // El argumento p_publicacion -> Property publicacion es oid = false
                // Lista de oids id
                linPedEN.Publicacion = new ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN ();
                linPedEN.Publicacion.Id = p_publicacion;
        }



        oid = _ILinPedRepository.New_ (linPedEN);
        return oid;
}

public void Modify (int p_LinPed_OID, int p_Cantidad, float p_precio)
{
        LinPedEN linPedEN = null;

        //Initialized LinPedEN
        linPedEN = new LinPedEN ();
        linPedEN.Id = p_LinPed_OID;
        linPedEN.Cantidad = p_Cantidad;
        linPedEN.Precio = p_precio;
        //Call to LinPedRepository

        _ILinPedRepository.Modify (linPedEN);
}

public void Destroy (int id
                     )
{
        _ILinPedRepository.Destroy (id);
}

public LinPedEN ReadOID (int id
                         )
{
        LinPedEN linPedEN = null;

        linPedEN = _ILinPedRepository.ReadOID (id);
        return linPedEN;
}

public System.Collections.Generic.IList<LinPedEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<LinPedEN> list = null;

        list = _ILinPedRepository.ReadAll (first, size);
        return list;
}
}
}
