
namespace _04_SupermarketDatabase
{
    class Product
    {
        public Product(string name, double price, int qty)
        {
            this.Name = name;
            this.Price = price;
            this.Qty = qty; 
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

    }
}
