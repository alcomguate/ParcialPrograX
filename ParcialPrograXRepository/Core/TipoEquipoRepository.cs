using ParcialPrograXModelo.Entidades;
using ParcialPrograXRepository.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialPrograXRepository.Core
{
    public class TipoEquipoRepository : ITipoEquipoRepository
    {

        private readonly ParcialDbContext _dbContext;

        public TipoEquipoRepository(ParcialDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<TipoEquipo> List()
        {
            return _dbContext.TipoEquipos;
        }
    }
}
