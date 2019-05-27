using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcialPrograXModelo.Entidades
{
    [Table("Equipos")]
    public partial class Equipo
    {
        
        [Required]
        public int id { get; set; }
        
        public int tipoid { get; set; }

        [ForeignKey("tipoid")]
        public TipoEquipo TipoEquipo { get; set; }

        
        public int marcaid { get; set; }

        [ForeignKey("marcaid")]
        public Marca Marca { get; set; }

        public decimal precio { get; set; }
        
    }
}
