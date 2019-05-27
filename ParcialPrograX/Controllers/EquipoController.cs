using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParcialPrograXDatos.Equipos;
using ParcialPrograXModelo.Entidades;
using ParcialPrograXRepository.Core.Interfaces;

namespace ParcialPrograX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {

        private readonly IEquipo _equipoService;
        private readonly IEquipoRepository _equipoRep;

        public EquipoController(IEquipo equipoService, IEquipoRepository equipoRep) {
            _equipoService = equipoService;
            _equipoRep = equipoRep;
        }

        // GET: api/Equipo
        [HttpGet]
        public IEnumerable<Equipo> Get()
        {
            return _equipoRep.List();
        }

        // GET: api/Equipo/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Equipo
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Equipo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
