using System.Collections.Generic;
using System.Threading.Tasks;
using SP3Project.API.Models;

namespace SP3Project.API.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
         Task<IEnumerable<Product>> GetAllProducts();
         Task<Product> GetProductByID(int id);
         void CreateProduct(Product product);
         void DeleteProduct(Product product);
         void UpdateProduct(Product product);
         

         
    }
}