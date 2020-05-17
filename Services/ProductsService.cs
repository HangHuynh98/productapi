using System.Collections.Generic;
using System.Linq;
using apiTest2.Model;

namespace apiTest2.Services
{

    public class ProductsService: IProductsService
    {

        // private List<Product> _productItems;
        private ProductContext _context;

        // public ProductsService()
        // {
        //     _productItems = new List<Product>();
        // }
        public ProductsService (ProductContext context)
        {
            _context=context;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public bool AddProduct(Product productItem)
        {
           try
           {
            _context.Add(productItem);
            _context.SaveChanges();
               
           }
           catch (System.Exception)
           {
               
               return false;
           } 
            return true;
        }

        public bool UpdateProduct(Product productItem)
        {
            try
            {
            var product = _context.Products.FirstOrDefault(x=> x.ID == productItem.ID);
            product.Name= productItem.Name;
            product.Brand= productItem.Brand;
             _context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(x=> x.ID==id);
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                _context.Products.Remove(GetProductById(id));
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }
    }
}