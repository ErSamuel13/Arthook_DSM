
using System;
using System.Text;
using System.Collections.Generic;
using ArthookGen.ApplicationCore.Exceptions;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.ApplicationCore.IRepository.Arthook;
using ArthookGen.ApplicationCore.CEN.Arthook;



namespace ArthookGen.ApplicationCore.CP.Arthook
{
public partial class MetodoPagoCP : GenericBasicCP
{
public MetodoPagoCP(GenericSessionCP currentSession)
        : base (currentSession)
{
}
}
}
