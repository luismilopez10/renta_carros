﻿using System;
using System.Collections.Generic;
using System.Text;

using pryRentaCarros.Model.EstacionCarga;

namespace pryRentaCarros.Broker.Interface
{
    public interface IEstacionCarga
    {
        string fncIngresarEstacionCarga(mdlEstacionCarga objMdlEstacionCarga);
        string fncModificarEstacionCarga(mdlEstacionCarga objMdlEstacionCarga);
        string fncRetirarEstacionCarga(mdlEstacionCarga objMdlEstacionCarga);
        List<mdlEstacionCarga> fncConsultarEstacionCarga(mdlEstacionCarga objMdlEstacionCarga);
    }
}
