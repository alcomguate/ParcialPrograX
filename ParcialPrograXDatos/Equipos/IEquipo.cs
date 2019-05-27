using System;
using System.Collections.Generic;
using System.Text;
using ParcialPrograXModelo.Entidades;

namespace ParcialPrograXDatos.Equipos
{
    public interface IEquipo
    {

        List<Equipo> GetAllEquipos(IEnumerable<Equipo> equipos);

    }
}
