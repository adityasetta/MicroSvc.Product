namespace MicroSvc.Product.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MicroSvc.Product.Domain.Entities;
    using MicroSvc.Product.ApplicationService.Interfaces;

    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> logger;

        private readonly IProductService productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            this.logger = logger;
            this.productService = productService;
        }

        [HttpGet]
        [Route("api/product")]
        public async Task<ActionResult<List<Product>>> GetProductAsync()
        {
                return await productService.GetProducts().ConfigureAwait(false);
        }

        [HttpPost]
        [Route("api/product/add")]
        public async Task<ActionResult> AddProductAsync([FromBody] List<Product> products)
        {
            await productService.AddProduct(products);
            return this.Ok();
        }

        [HttpPost]
        [Route("api/product/edit")]
        public async Task<ActionResult> EditProductAsync([FromBody] Product products)
        {
            await productService.EditProduct(products);
            return this.Ok();
        }

        [HttpPost]
        [Route("api/product/delete")]
        public async Task<ActionResult> DeleteProductAsync([FromBody] Product products)
        {
            await productService.DeleteProduct(products);
            return this.Ok();
        }
    }
}
