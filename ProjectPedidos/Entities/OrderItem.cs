using System;
using System.Globalization;


namespace ProjectPedidos.Entities
{
     class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Products { get; set; }


        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Products = product;
        }

        public double SubTotal()
        {
            return Quantity * Price; 
        }

        public override string ToString()
        {
            return Products.Name +
                ", $" +
                Price.ToString("F2", CultureInfo.InvariantCulture) +
                " Quantity: " +
                Quantity +
                ", SubTotal: $" +
                SubTotal().ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}
