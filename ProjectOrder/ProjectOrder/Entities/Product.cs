namespace ProjectOrder.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; private set; }

        public Product()
        {
        }
    
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
