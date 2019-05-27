using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParcialPrograXDatos.Equipos;
using ParcialPrograXModelo.Entidades;

namespace ParcialPrograX.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IEquipo _equipoService;

        // Constructor del cotrolador
        public ValuesController(IEquipo equipoService) {
            _equipoService = equipoService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Equipo> Get(int id)
        {
            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
