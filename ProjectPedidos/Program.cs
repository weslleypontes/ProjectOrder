using System;
using System.Globalization;
using ProjectPedidos.Entities.Enums;
using ProjectPedidos.Entities;
namespace ProjectPedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client cliente = new Client(nome, email, date);
            Order order = new Order(DateTime.Now, status, cliente);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i=1; i<=n;i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nomeP = Console.ReadLine();
                Console.Write("Product price: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(nomeP, preco);

                Console.Write("Quantity: ");
                int quantidade = int.Parse(Console.ReadLine());
                
                OrderItem orderitem = new OrderItem(quantidade, preco, product);

                order.AddItem(orderitem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}
