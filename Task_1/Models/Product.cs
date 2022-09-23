namespace Task_1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
     
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product() { Id = 1, Name = "Samsumg s500", Price = 600.50 },
                new Product() { Id = 2, Name = "Lg D32", Price = 1523 },
                new Product() { Id = 3, Name = "Sony s3", Price = 25065.85 },
                new Product() { Id = 4, Name = "Toshiba n32", Price = 152369 },
                new Product() { Id = 5, Name = "Lenovo a12", Price = 57896.3 }
            };
        }
    }
}
