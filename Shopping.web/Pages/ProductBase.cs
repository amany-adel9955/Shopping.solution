using Microsoft.AspNetCore.Components;
using Shopping.Bl.Dtos;
using Shopping.web.Services.Contracts;

namespace Shopping.web.Pages
{

        public class ProductBase : ComponentBase
        {
            [Inject]
            public IProductService productService { get; set; }

            public IEnumerable<ProductDto> products { get; set; } // No "required" keyword

            protected override async Task OnInitializedAsync()
            {
                products = await productService.GetAllProducts();
            }
        }
    
}
