using System;
using System.Collections.Generic;
using System.Text;

using pryRentaCarros.Broker.Operation;
using pryRentaCarros.Model.EstacionCarga;

namespace pryRentaCarros.BusinessRule.EstacionCarga
{
    public class clsEstacionCarga : IEstacionCarga
    {
        private optEstacionCarga objOptEstacionCarga = null;
        public clsEstacionCarga()
        {
            objOptEstacionCarga = new optEstacionCarga();
        }
        public string fncIngresarEstacionCarga(mdlEstacionCarga objMdlEstacionCarga)
        {
            return objOptEstacionCarga.fncIngresarEstacionCarga(objMdlEstacionCarga);
        }

        public string fncModificarEstacionCarga(mdlEstacionCarga objMdlEstacionCarga)
        {
            return objOptEstacionCarga.fncModificarEstacionCarga(objMdlEstacionCarga);
        }

        public string fncRetirarEstacionCarga(mdlEstacionCarga objMdlEstacionCarga)
        {
            return objOptEstacionCarga.fncRetirarEstacionCarga(objMdlEstacionCarga);
        }

        public List<mdlEstacionCarga> fncConsultarEstacionCarga(mdlEstacionCarga objMdlEstacionCarga)
        {
            return objOptEstacionCarga.fncConsultarEstacionCarga(objMdlEstacionCarga);
        }
    }
}
