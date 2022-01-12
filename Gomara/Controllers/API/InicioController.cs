using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gomara.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class InicioController : ControllerBase
    {
        // GET: api/v1/<InicioController>
        [HttpGet]
        public string Get()
        {
            return "Se Inicia el Proyecto Gomara.API";
        }
    }
}
