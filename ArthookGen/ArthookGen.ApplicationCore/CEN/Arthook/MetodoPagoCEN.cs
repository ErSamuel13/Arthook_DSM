

using System;
using System.Text;
using System.Collections.Generic;

using ArthookGen.ApplicationCore.Exceptions;

using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;


namespace ArthookGen.ApplicationCore.CEN.Arthook
{
/*
 *      Definition of the class MetodoPagoCEN
 *
 */
public partial class MetodoPagoCEN
{
private IMetodoPagoRepository _IMetodoPagoRepository;

public MetodoPagoCEN(IMetodoPagoRepository _IMetodoPagoRepository)
{
        this._IMetodoPagoRepository = _IMetodoPagoRepository;
}

public IMetodoPagoRepository get_IMetodoPagoRepository ()
{
        return this._IMetodoPagoRepository;
}

public int New_ ()
{
        MetodoPagoEN metodoPagoEN = null;
        int oid;

        //Initialized MetodoPagoEN
        metodoPagoEN = new MetodoPagoEN ();


        oid = _IMetodoPagoRepository.New_ (metodoPagoEN);
        return oid;
}

public void Modify (int p_MetodoPago_OID)
{
        MetodoPagoEN metodoPagoEN = null;

        //Initialized MetodoPagoEN
        metodoPagoEN = new MetodoPagoEN ();
        metodoPagoEN.Id = p_MetodoPago_OID;
        //Call to MetodoPagoRepository

        _IMetodoPagoRepository.Modify (metodoPagoEN);
}

public void Destroy (int id
                     )
{
        _IMetodoPagoRepository.Destroy (id);
}

public MetodoPagoEN ReadOID (int id
                             )
{
        MetodoPagoEN metodoPagoEN = null;

        metodoPagoEN = _IMetodoPagoRepository.ReadOID (id);
        return metodoPagoEN;
}

public System.Collections.Generic.IList<MetodoPagoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MetodoPagoEN> list = null;

        list = _IMetodoPagoRepository.ReadAll (first, size);
        return list;
}
}
}
