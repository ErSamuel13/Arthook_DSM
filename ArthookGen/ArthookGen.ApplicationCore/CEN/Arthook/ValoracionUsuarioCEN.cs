

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

public int New_ (string p_puntuacion, int p_valorador, int p_valorado)
{
        ValoracionUsuarioEN valoracionUsuarioEN = null;
        int oid;

        //Initialized ValoracionUsuarioEN
        valoracionUsuarioEN = new ValoracionUsuarioEN ();
        valoracionUsuarioEN.Puntuacion = p_puntuacion;


        if (p_valorador != -1) {
                // El argumento p_valorador -> Property valorador es oid = false
                // Lista de oids id
                valoracionUsuarioEN.Valorador = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                valoracionUsuarioEN.Valorador.Id = p_valorador;
        }


        if (p_valorado != -1) {
                // El argumento p_valorado -> Property valorado es oid = false
                // Lista de oids id
                valoracionUsuarioEN.Valorado = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                valoracionUsuarioEN.Valorado.Id = p_valorado;
        }



        oid = _IValoracionUsuarioRepository.New_ (valoracionUsuarioEN);
        return oid;
}

public void Modify (int p_ValoracionUsuario_OID, string p_puntuacion)
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
}
}
