using Shopping.Bl.Dtos;

namespace Shopping.web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProducts();
    }
}
