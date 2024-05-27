using Shopping.API.Entities;

namespace Shopping.API.Repository.Contracts
{
    public interface IProductRepo
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<IEnumerable<ProductCategory>> GetAllCategories();
        Task<Product> GetProduct(int id);
        Task<ProductCategory> GetProductCategory(int id);
    }
}
