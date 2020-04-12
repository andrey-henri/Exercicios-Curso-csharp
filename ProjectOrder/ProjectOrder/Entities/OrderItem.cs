namespace ProjectOrder.Entities
{
    class OrderItem
    {
        public int quantity { get; private set; }
        public double price { get; set; }

        public Product Product { get; private set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            this.quantity = quantity;
            this.price = price;
            Product = product;
        }

        public double subTotal()
        {
            return quantity * price;
        }
    }
}
