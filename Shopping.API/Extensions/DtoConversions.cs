using Shopping.API.Entities;
using Shopping.Bl.Dtos;

namespace Shopping.API.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertToProductDto(this IEnumerable<Product> products , IEnumerable<ProductCategory> categories)
        { // i can do this by func delegate  .. func<product , category, dto> selector = (product, category) => new dto{}

            return (from product in products
                    join category in categories
                    on product.CategoryId equals category.Id
                    select new ProductDto
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        ImageUrl = product.ImageURL,
                        Price = product.Price,
                        CategoryId = product.CategoryId,
                        CategoryName = product.Name
                    }).ToList();

                    
        }
    }
}
