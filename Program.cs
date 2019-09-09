using EnumeraçõesEnum.Entidades;
using EnumeraçõesEnum.Entidades.Enums;
using System;

namespace EnumeraçõesEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = PedidoStatus.PagamentoPedente
            };
            Console.WriteLine(pedido);
        }
    }
}
