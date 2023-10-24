

using ArthookGen.ApplicationCore.IRepository.Arthook;
using ArthookGen.Infraestructure.Repository.Arthook;
using ArthookGen.Infraestructure.CP;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArthookGen.Infraestructure.Repository
{
public class UnitOfWorkRepository : GenericUnitOfWorkRepository
{
SessionCPNHibernate session;


public UnitOfWorkRepository(SessionCPNHibernate session)
{
        this.session = session;
}

public override IUsuarioRepository UsuarioRepository {
        get
        {
                this.usuariorepository = new UsuarioRepository ();
                this.usuariorepository.setSessionCP (session);
                return this.usuariorepository;
        }
}

public override IPublicacionRepository PublicacionRepository {
        get
        {
                this.publicacionrepository = new PublicacionRepository ();
                this.publicacionrepository.setSessionCP (session);
                return this.publicacionrepository;
        }
}

public override IPedidoRepository PedidoRepository {
        get
        {
                this.pedidorepository = new PedidoRepository ();
                this.pedidorepository.setSessionCP (session);
                return this.pedidorepository;
        }
}

public override ILinPedRepository LinPedRepository {
        get
        {
                this.linpedrepository = new LinPedRepository ();
                this.linpedrepository.setSessionCP (session);
                return this.linpedrepository;
        }
}

public override ITarifaRepository TarifaRepository {
        get
        {
                this.tarifarepository = new TarifaRepository ();
                this.tarifarepository.setSessionCP (session);
                return this.tarifarepository;
        }
}

public override IDevolucionRepository DevolucionRepository {
        get
        {
                this.devolucionrepository = new DevolucionRepository ();
                this.devolucionrepository.setSessionCP (session);
                return this.devolucionrepository;
        }
}

public override IMetodoPagoRepository MetodoPagoRepository {
        get
        {
                this.metodopagorepository = new MetodoPagoRepository ();
                this.metodopagorepository.setSessionCP (session);
                return this.metodopagorepository;
        }
}

public override IMensajeRepository MensajeRepository {
        get
        {
                this.mensajerepository = new MensajeRepository ();
                this.mensajerepository.setSessionCP (session);
                return this.mensajerepository;
        }
}

public override IValoracionPublicacionRepository ValoracionPublicacionRepository {
        get
        {
                this.valoracionpublicacionrepository = new ValoracionPublicacionRepository ();
                this.valoracionpublicacionrepository.setSessionCP (session);
                return this.valoracionpublicacionrepository;
        }
}

public override IValoracionUsuarioRepository ValoracionUsuarioRepository {
        get
        {
                this.valoracionusuariorepository = new ValoracionUsuarioRepository ();
                this.valoracionusuariorepository.setSessionCP (session);
                return this.valoracionusuariorepository;
        }
}
}
}

