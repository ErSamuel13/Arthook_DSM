
using System;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.CP.Arthook;

namespace ArthookGen.ApplicationCore.IRepository.Arthook
{
public partial interface ILinPedRepository
{
void setSessionCP (GenericSessionCP session);

LinPedEN ReadOIDDefault (int id
                         );

void ModifyDefault (LinPedEN linPed);

System.Collections.Generic.IList<LinPedEN> ReadAllDefault (int first, int size);



int New_ (LinPedEN linPed);

void Modify (LinPedEN linPed);


void Destroy (int id
              );


LinPedEN ReadOID (int id
                  );


System.Collections.Generic.IList<LinPedEN> ReadAll (int first, int size);
}
}
