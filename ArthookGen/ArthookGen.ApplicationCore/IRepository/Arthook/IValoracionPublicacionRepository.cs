
using System;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.CP.Arthook;

namespace ArthookGen.ApplicationCore.IRepository.Arthook
{
public partial interface IValoracionPublicacionRepository
{
void setSessionCP (GenericSessionCP session);

ValoracionPublicacionEN ReadOIDDefault (int id
                                        );

void ModifyDefault (ValoracionPublicacionEN valoracionPublicacion);

System.Collections.Generic.IList<ValoracionPublicacionEN> ReadAllDefault (int first, int size);



int New_ (ValoracionPublicacionEN valoracionPublicacion);

void Modify (ValoracionPublicacionEN valoracionPublicacion);


void Destroy (int id
              );


ValoracionPublicacionEN ReadOID (int id
                                 );


System.Collections.Generic.IList<ValoracionPublicacionEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.ValoracionPublicacionEN> FiltrarXvaloracion (int ? idPub);
}
}
