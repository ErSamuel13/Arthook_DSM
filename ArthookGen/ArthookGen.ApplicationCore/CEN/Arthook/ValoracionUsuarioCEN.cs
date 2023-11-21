

using System;
using System.Text;
using System.Collections.Generic;

using ArthookGen.ApplicationCore.Exceptions;

using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;


namespace ArthookGen.ApplicationCore.CEN.Arthook
{
/*
 *      Definition of the class ValoracionUsuarioCEN
 *
 */
public partial class ValoracionUsuarioCEN
{
private IValoracionUsuarioRepository _IValoracionUsuarioRepository;

public ValoracionUsuarioCEN(IValoracionUsuarioRepository _IValoracionUsuarioRepository)
{
        this._IValoracionUsuarioRepository = _IValoracionUsuarioRepository;
}

public IValoracionUsuarioRepository get_IValoracionUsuarioRepository ()
{
        return this._IValoracionUsuarioRepository;
}

public void Modify (int p_ValoracionUsuario_OID, float p_puntuacion)
{
        ValoracionUsuarioEN valoracionUsuarioEN = null;

        //Initialized ValoracionUsuarioEN
        valoracionUsuarioEN = new ValoracionUsuarioEN ();
        valoracionUsuarioEN.Id = p_ValoracionUsuario_OID;
        valoracionUsuarioEN.Puntuacion = p_puntuacion;
        //Call to ValoracionUsuarioRepository

        _IValoracionUsuarioRepository.Modify (valoracionUsuarioEN);
}

public void Destroy (int id
                     )
{
        _IValoracionUsuarioRepository.Destroy (id);
}

public ValoracionUsuarioEN ReadOID (int id
                                    )
{
        ValoracionUsuarioEN valoracionUsuarioEN = null;

        valoracionUsuarioEN = _IValoracionUsuarioRepository.ReadOID (id);
        return valoracionUsuarioEN;
}

public System.Collections.Generic.IList<ValoracionUsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ValoracionUsuarioEN> list = null;

        list = _IValoracionUsuarioRepository.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> FiltrarXValoracion (int ? idUsu)
{
        return _IValoracionUsuarioRepository.FiltrarXValoracion (idUsu);
}
}
}