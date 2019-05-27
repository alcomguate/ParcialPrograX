using System;
using System.Collections.Generic;
using System.Text;
using ParcialPrograXModelo.Entidades;

namespace ParcialPrograXDatos.Equipos
{
    public class EquipoServicio : IEquipo
    {
        public List<Equipo> GetAllEquipos(IEnumerable<Equipo> equipos)
        {
            List<Equipo> resultado = new List<Equipo>();
            foreach (Equipo e in equipos) {
                Equipo equipo = new Equipo();
                equipo.id = e.id;
                
                resultado.Add(equipo);
            }
            return resultado;
        }
    }
}
