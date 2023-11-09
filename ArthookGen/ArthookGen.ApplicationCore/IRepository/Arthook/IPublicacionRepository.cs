
using System;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.CP.Arthook;

namespace ArthookGen.ApplicationCore.IRepository.Arthook
{
public partial interface IPublicacionRepository
{
void setSessionCP (GenericSessionCP session);

PublicacionEN ReadOIDDefault (int id
                              );

void ModifyDefault (PublicacionEN publicacion);

System.Collections.Generic.IList<PublicacionEN> ReadAllDefault (int first, int size);



int New_ (PublicacionEN publicacion);

void Modify (PublicacionEN publicacion);


void Destroy (int id
              );


PublicacionEN ReadOID (int id
                       );


System.Collections.Generic.IList<PublicacionEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ArthookGen.ApplicationCore.EN.Arthook.PublicacionEN> FiltrarXUsuario (int ? id);
}
}
