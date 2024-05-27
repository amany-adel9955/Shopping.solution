using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping.API.Extensions;
using Shopping.API.UnitOfWork;
using Shopping.Bl.Dtos;
using Shopping.Bl.Response;

namespace Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllproducts()
        {
            try
            {
                var products = await _unitOfWork.ProductRepo.GetAllProducts();
                var categories = await _unitOfWork.ProductRepo.GetAllCategories();

                if (products is null || categories is null)
                {
                    return NotFound(new GeneralResponse() { StatusCode = 404, Message = "No Products Found" });
                }
                else
                {
                    var productdto = products.ConvertToProductDto(categories);
                    return Ok(productdto);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Invalid retriving data from database");
            }
        }


    }
}
