using EnumeraçõesEnum.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnumeraçõesEnum.Entidades
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public PedidoStatus Status{ get; set; }

        public override string ToString()
        {
            return Id
                + ","
                + Moment
                + ","
                + Status;
        }
    }
}
