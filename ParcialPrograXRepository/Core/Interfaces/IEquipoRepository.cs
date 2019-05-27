using ParcialPrograXModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialPrograXRepository.Core.Interfaces
{
    public interface IEquipoRepository
    {
        IEnumerable<Equipo> List();

    }
}
