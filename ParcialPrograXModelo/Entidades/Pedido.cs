using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialPrograXModelo.Entidades
{
    public class Pedido
    {

        public int numeroPedido { get; set; }
        public Vendedor vendedor { get; set; }
        public DateTime fecha_pedido { get; set; }
        public DateTime fecha_entrega { get; set; }
        public string direccion_entrega { get; set; }

    }
}
