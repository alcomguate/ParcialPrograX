using ParcialPrograXModelo.Entidades;
using ParcialPrograXRepository.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialPrograXRepository.Core
{
    public class MarcaRepository : IMarcaRepository
    {

        private readonly ParcialDbContext _dbContext;

        public MarcaRepository(ParcialDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Marca findById(int id)
        {
            return _dbContext.Marcas.Find(id);
        }

        public IEnumerable<Marca> List()
        {
            return _dbContext.Marcas;
        }
    }
}
