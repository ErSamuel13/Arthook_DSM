

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

public void Modify (int p_LinPed_OID, int p_cantidad)
{
        LinPedEN linPedEN = null;

        //Initialized LinPedEN
        linPedEN = new LinPedEN ();
        linPedEN.Id = p_LinPed_OID;
        linPedEN.Cantidad = p_cantidad;
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
