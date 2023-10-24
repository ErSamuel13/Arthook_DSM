

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

public int New_ (float p_puntuacion, int p_usuarioValorador, int p_usuarioValorado)
{
        ValoracionUsuarioEN valoracionUsuarioEN = null;
        int oid;

        //Initialized ValoracionUsuarioEN
        valoracionUsuarioEN = new ValoracionUsuarioEN ();
        valoracionUsuarioEN.Puntuacion = p_puntuacion;


        if (p_usuarioValorador != -1) {
                // El argumento p_usuarioValorador -> Property usuarioValorador es oid = false
                // Lista de oids id
                valoracionUsuarioEN.UsuarioValorador = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                valoracionUsuarioEN.UsuarioValorador.Id = p_usuarioValorador;
        }


        if (p_usuarioValorado != -1) {
                // El argumento p_usuarioValorado -> Property usuarioValorado es oid = false
                // Lista de oids id
                valoracionUsuarioEN.UsuarioValorado = new ArthookGen.ApplicationCore.EN.Arthook.UsuarioEN ();
                valoracionUsuarioEN.UsuarioValorado.Id = p_usuarioValorado;
        }



        oid = _IValoracionUsuarioRepository.New_ (valoracionUsuarioEN);
        return oid;
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
}
}
