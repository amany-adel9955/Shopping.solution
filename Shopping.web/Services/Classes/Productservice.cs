using Microsoft.Extensions.Logging;
using Shopping.Bl.Dtos;
using Shopping.web.Services.Contracts;
using System.Net.Http.Json;

namespace Shopping.web.Services.Classes
{
    public class Productservice : IProductService
    {
        private readonly HttpClient _httpclient;

        public Productservice(HttpClient httpClient)
        {
            _httpclient = httpClient;  
        }
        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            try
            {
                var products = await _httpclient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return products;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
