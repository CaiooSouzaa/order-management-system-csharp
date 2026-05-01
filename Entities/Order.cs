using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    namespace Exercicios.Ex10
{
        public class Order
        {
            public DateTime Moment { get; set; }
            public OrderStatus Status { get; set; }

            public Client Client { get; set; }

            public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

            public Order(){}

            public Order(DateTime moment, OrderStatus status, Client client)
            {
                Moment = moment;
                Status = status;
                Client = client;
            }

            public void AddItem(OrderItem item)
            {
                Itens.Add(item);
            }

            public void RemoveItem(OrderItem item)
            {
                Itens.Remove(item);
            }

            public double Total()
            {
                double soma = 0;

                foreach(OrderItem oI in Itens)
                {
                    soma += oI.SubTotal();
                }
                return soma;
            }
        }
}