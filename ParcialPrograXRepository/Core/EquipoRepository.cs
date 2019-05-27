using ParcialPrograXModelo.Entidades;
using ParcialPrograXRepository.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialPrograXRepository.Core
{
    public class EquipoRepository: IEquipoRepository
    {

        private readonly ParcialDbContext _dbContext;

        public EquipoRepository(ParcialDbContext dbContext) {
            _dbContext = dbContext;
        }

        public IEnumerable<Equipo> List()
        {
            return _dbContext.Equipos;
        }

    }
}
