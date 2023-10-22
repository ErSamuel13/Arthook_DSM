
using System;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.CP.Arthook;

namespace ArthookGen.ApplicationCore.IRepository.Arthook
{
public partial interface ITarifaRepository
{
void setSessionCP (GenericSessionCP session);

TarifaEN ReadOIDDefault (int id
                         );

void ModifyDefault (TarifaEN tarifa);

System.Collections.Generic.IList<TarifaEN> ReadAllDefault (int first, int size);



int New_ (TarifaEN tarifa);

void Modify (TarifaEN tarifa);


void Destroy (int id
              );


TarifaEN ReadOID (int id
                  );


System.Collections.Generic.IList<TarifaEN> ReadAll (int first, int size);
}
}
