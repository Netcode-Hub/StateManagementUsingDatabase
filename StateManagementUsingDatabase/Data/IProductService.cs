namespace StateManagementUsingDatabase.Data
{
    public interface IProductService
    {
        Task AddProduct(Product model);
        Task<List<Product>> GetAllProducts();
        Task<int> GetProductCount();
    }
}
