using System;
using System.Collections.Generic;
using System.Text;

namespace pryRentaCarros.Model.EstacionCarga
{
    public class mdlEstacionCarga
    {
        public int intIdEstacionCarga { get; set; }
        public string strNombre { get; set; }
        public double dblLatitud { get; set; }
        public double dblLongitud { get; set; }
        public bool blnActivo { get; set; }
        public DateTime dtmActualiza { get; set; }
    }
}
