
using Microsoft.EntityFrameworkCore;

namespace StateManagementUsingDatabase.Data
{
    public class ProductService : IProductService
    {
        private readonly AppDbcontext appDbcontext;
        public ProductService(AppDbcontext appDbcontext)
        {
            this.appDbcontext = appDbcontext;
        }

        public async Task AddProduct(Product model)
        {
            appDbcontext.Products.Add(model);
            await appDbcontext.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllProducts() => await appDbcontext.Products.ToListAsync();

        public async Task<int> GetProductCount()
        {
            var products = await appDbcontext.Products.ToListAsync();
            return products.Count;
        }
    }
}
