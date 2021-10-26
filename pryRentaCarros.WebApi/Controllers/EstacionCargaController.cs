using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using pryRentaCarros.Model.EstacionCarga;
using pryRentaCarros.BusinessRule.EstacionCarga;

namespace pryRentaCarros.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EstacionCargaController : ControllerBase
    {

        [HttpPost]
        [Route("Ingresar")]
        public string fncIngresarEstacionCarga(string strNombre, double dblLatitud, double dblLongitud)
        {
            mdlEstacionCarga objMdlEstacionCarga = new mdlEstacionCarga();
            clsEstacionCarga objClsEstacionCarga = new clsEstacionCarga();
            objMdlEstacionCarga.strNombre = strNombre;
            objMdlEstacionCarga.dblLatitud = dblLatitud;
            objMdlEstacionCarga.dblLongitud = dblLongitud;
            return objClsEstacionCarga.fncIngresarEstacionCarga(objMdlEstacionCarga);
        }

        [HttpPut]
        [Route("Modificar")]
        public string fncModificarEstacionCarga(int intIdEstacionCarga, string strNombre, double dblLatitud, double dblLongitud)
        {
            mdlEstacionCarga objMdlEstacionCarga = new mdlEstacionCarga();
            clsEstacionCarga objClsEstacionCarga = new clsEstacionCarga();
            objMdlEstacionCarga.intIdEstacionCarga = intIdEstacionCarga;
            objMdlEstacionCarga.strNombre = strNombre;
            objMdlEstacionCarga.dblLatitud = dblLatitud;
            objMdlEstacionCarga.dblLongitud = dblLongitud;
            return objClsEstacionCarga.fncModificarEstacionCarga(objMdlEstacionCarga);
        }

        [HttpDelete]
        [Route("Retirar")]
        public string fncRetirarEstacionCarga(int intIdEstacionCarga)
        {
            mdlEstacionCarga objMdlEstacionCarga = new mdlEstacionCarga();
            clsEstacionCarga objClsEstacionCarga = new clsEstacionCarga();
            objMdlEstacionCarga.intIdEstacionCarga = intIdEstacionCarga;
            return objClsEstacionCarga.fncRetirarEstacionCarga(objMdlEstacionCarga);
        }


        [HttpGet]
        [Route("Consultar")]
        public List<mdlEstacionCarga> fncConsultarEstacionCarga()
        {
            mdlEstacionCarga objMdlEstacionCarga = new mdlEstacionCarga();
            clsEstacionCarga objClsEstacionCarga = new clsEstacionCarga();
            return objClsEstacionCarga.fncConsultarEstacionCarga(objMdlEstacionCarga);
        }
    }
}
