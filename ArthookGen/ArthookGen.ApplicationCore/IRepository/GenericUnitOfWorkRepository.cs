
using System;
using System.Collections.Generic;
using System.Text;

namespace ArthookGen.ApplicationCore.IRepository.Arthook
{
public abstract class GenericUnitOfWorkRepository
{
protected IPublicacionRepository publicacionrepository;
protected IPedidoRepository pedidorepository;
protected ILinPedRepository linpedrepository;
protected IMensajeRepository mensajerepository;
protected IValoracionUsuarioRepository valoracionusuariorepository;
protected IValoracionPublicacionRepository valoracionpublicacionrepository;
protected IDevolucionRepository devolucionrepository;
protected ITarifaRepository tarifarepository;
protected IUsuarioRepository usuariorepository;
protected IMetodoPagoRepository metodopagorepository;


public abstract IPublicacionRepository PublicacionRepository {
        get;
}
public abstract IPedidoRepository PedidoRepository {
        get;
}
public abstract ILinPedRepository LinPedRepository {
        get;
}
public abstract IMensajeRepository MensajeRepository {
        get;
}
public abstract IValoracionUsuarioRepository ValoracionUsuarioRepository {
        get;
}
public abstract IValoracionPublicacionRepository ValoracionPublicacionRepository {
        get;
}
public abstract IDevolucionRepository DevolucionRepository {
        get;
}
public abstract ITarifaRepository TarifaRepository {
        get;
}
public abstract IUsuarioRepository UsuarioRepository {
        get;
}
public abstract IMetodoPagoRepository MetodoPagoRepository {
        get;
}
}
}
