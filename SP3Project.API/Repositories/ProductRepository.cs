using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SP3Project.API.Contracts;
using SP3Project.API.Data;
using SP3Project.API.Models;

namespace SP3Project.API.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }

        public void CreateProduct(Product product)
        {
            Create(product);
        }

        public void DeleteProduct(Product product)
        {
            Delete(product);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<Product> GetProductByID(int id)
        {
            return await FindByCondition(product => product.ProductID == id).FirstOrDefaultAsync();
        }

        public void UpdateProduct(Product product)
        {
            Update(product);
        }
    }
}