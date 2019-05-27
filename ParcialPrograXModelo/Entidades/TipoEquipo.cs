using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ParcialPrograXModelo.Entidades
{

    [Table("TipoEquipo")]
    public class TipoEquipo
    {

        public int id { get; set; }
        public string descripcion { get; set; }
        
        public ICollection<Equipo> Equipos { get; set; }

    }
}
