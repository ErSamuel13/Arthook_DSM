
using System;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.CP.Arthook;

namespace ArthookGen.ApplicationCore.IRepository.Arthook
{
public partial interface IValoracionUsuarioRepository
{
void setSessionCP (GenericSessionCP session);

ValoracionUsuarioEN ReadOIDDefault (int id
                                    );

void ModifyDefault (ValoracionUsuarioEN valoracionUsuario);

System.Collections.Generic.IList<ValoracionUsuarioEN> ReadAllDefault (int first, int size);



int New_ (ValoracionUsuarioEN valoracionUsuario);

void Modify (ValoracionUsuarioEN valoracionUsuario);


void Destroy (int id
              );


ValoracionUsuarioEN ReadOID (int id
                             );


System.Collections.Generic.IList<ValoracionUsuarioEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionUsuarioEN> FiltrarXValoracion (int ? idUsu);
}
}
