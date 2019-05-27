using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialPrograXModelo.Entidades
{
    public class PedidoDet
    {

        public Pedido pedido { get; set; }
        public int noDetalle { get; set; }
        public Equipo equipo { get; set; }
        public decimal cantidad { get; set; }

    }
}
