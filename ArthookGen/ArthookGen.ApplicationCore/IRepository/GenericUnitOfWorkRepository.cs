
using System;
using System.Collections.Generic;
using System.Text;

namespace ArthookGen.ApplicationCore.IRepository.Arthook
{
public abstract class GenericUnitOfWorkRepository
{
protected IUsuarioRepository usuariorepository;
protected IPublicacionRepository publicacionrepository;
protected IPedidoRepository pedidorepository;
protected ILinPedRepository linpedrepository;
protected ITarifaRepository tarifarepository;
protected IDevolucionRepository devolucionrepository;
protected IMetodoPagoRepository metodopagorepository;
protected IMensajeRepository mensajerepository;
protected IValoracionRepository valoracionrepository;


public abstract IUsuarioRepository UsuarioRepository {
        get;
}
public abstract IPublicacionRepository PublicacionRepository {
        get;
}
public abstract IPedidoRepository PedidoRepository {
        get;
}
public abstract ILinPedRepository LinPedRepository {
        get;
}
public abstract ITarifaRepository TarifaRepository {
        get;
}
public abstract IDevolucionRepository DevolucionRepository {
        get;
}
public abstract IMetodoPagoRepository MetodoPagoRepository {
        get;
}
public abstract IMensajeRepository MensajeRepository {
        get;
}
public abstract IValoracionRepository ValoracionRepository {
        get;
}
}
}
