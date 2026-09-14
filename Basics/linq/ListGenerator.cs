namespace linq
{
    public class Product : IComparable<Product>
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; } = "";
        public string ProductCategory { get; set; } = "";
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public int CompareTo(Product? other)
        {
            if (other is null) return 1;
            return UnitPrice.CompareTo(other.UnitPrice);
        }

        public override string ToString()
        {
            return $"ProductId:{ProductId},ProductName:{ProductName},ProductCategory:{ProductCategory},UnitPrice:{UnitPrice},UnitsInStock:{UnitsInStock}";
        }
    }

    public static class ListGenerator
    {
        public static List<Product> ProductList;

        static ListGenerator()
        {
            ProductList = new List<Product>
            {
                new Product { ProductId = 11, ProductName = "Product 11", ProductCategory = "Category 11", UnitPrice = 200, UnitsInStock = 90 },
                new Product { ProductId = 5, ProductName = "Product 5", ProductCategory = "Category 5", UnitPrice = 500, UnitsInStock = 50 },
                new Product { ProductId = 6, ProductName = "Product 6", ProductCategory = "Category 6", UnitPrice = 600, UnitsInStock = 60 },
                new Product { ProductId = 1, ProductName = "Product 1", ProductCategory = "Category 1", UnitPrice = 100, UnitsInStock = 10 },
                new Product { ProductId = 7, ProductName = "Product 7", ProductCategory = "Category 7", UnitPrice = 700, UnitsInStock = 70 },
                new Product { ProductId = 10, ProductName = "Product 10", ProductCategory = "Category 10", UnitPrice = 1000, UnitsInStock = 100 },
                new Product { ProductId = 9, ProductName = "Product 9", ProductCategory = "Category 9", UnitPrice = 8900, UnitsInStock = 20 },
                new Product { ProductId = 3, ProductName = "Product 3", ProductCategory = "Category 3", UnitPrice = 300, UnitsInStock = 30 },
                new Product { ProductId = 8, ProductName = "Product 8", ProductCategory = "Category 8", UnitPrice = 800, UnitsInStock = 80 },
                new Product { ProductId = 4, ProductName = "Product 4", ProductCategory = "Category 4", UnitPrice = 400, UnitsInStock = 40 },
                new Product { ProductId = 2, ProductName = "Product 2", ProductCategory = "Category 2", UnitPrice = 200, UnitsInStock = 90 },
            };
        }
    }
}