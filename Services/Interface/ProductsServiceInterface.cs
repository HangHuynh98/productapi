using System.Collections.Generic;
using apiTest2.Model;

namespace apiTest2.Services
{
    public interface IProductsService
    {
        public List<Product> GetProducts();
        public Product GetProductById(int id);

        public bool AddProduct(Product productItem);

        public bool UpdateProduct(Product productItem);

        public bool DeleteProduct(int id);
    }
}