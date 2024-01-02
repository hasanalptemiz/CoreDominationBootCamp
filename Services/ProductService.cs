using CoreDominationBootCamp.Models;
namespace CoreDominationBootCamp.Services
{
    public class ProductService
    {
        private static List<Product> products = new List<Product>
        {
            new Product(1, "Laptop", 1200.00m, new Category(1, "Electronics")),
            new Product(2, "Smartphone", 800.00m, new Category(1, "Electronics")),
            new Product(3, "Headphones", 100.00m, new Category(1, "Electronics")),
            new Product(4, "Book", 20.00m, new Category(2, "Books")),
            // Diğer ürünleri buraya ekleyebilirsiniz.
        };

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int productId)
        {
            return products.Find(p => p.ID == productId);
        }

        public void AddProduct(Product newProduct)
        {
            products.Add(newProduct);
        }

        public void DeleteProduct(int productId)
        {
            var product = products.Find(p => p.ID == productId);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}