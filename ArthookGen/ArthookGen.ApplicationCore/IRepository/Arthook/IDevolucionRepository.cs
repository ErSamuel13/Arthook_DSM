
using System;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.CP.Arthook;

namespace ArthookGen.ApplicationCore.IRepository.Arthook
{
public partial interface IDevolucionRepository
{
void setSessionCP (GenericSessionCP session);

DevolucionEN ReadOIDDefault (int id
                             );

void ModifyDefault (DevolucionEN devolucion);

System.Collections.Generic.IList<DevolucionEN> ReadAllDefault (int first, int size);



int New_ (DevolucionEN devolucion);

void Modify (DevolucionEN devolucion);


void Destroy (int id
              );


DevolucionEN ReadOID (int id
                      );


System.Collections.Generic.IList<DevolucionEN> ReadAll (int first, int size);
}
}
