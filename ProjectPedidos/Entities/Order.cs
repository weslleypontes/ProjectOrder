using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using ProjectPedidos.Entities.Enums;

namespace ProjectPedidos.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        
        //metodo para Adicionar uma item na Lista do tipo OrderItem, os dados vem da classe OrderItem
        // o metodo recebe como parametro da principal 
        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item) { 
           OrderItems.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in OrderItems)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Oder status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Intms");
            foreach(OrderItem item in OrderItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $"+Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
