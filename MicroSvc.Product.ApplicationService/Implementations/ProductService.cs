namespace MicroSvc.Product.ApplicationService.Implementations
{
    using MicroSvc.Product.ApplicationService.Interfaces;
    using MicroSvc.Product.Domain.Repositories;
    using MicroSvc.Product.Domain.Entities;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        private readonly IUnitOfWork unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this.productRepository = productRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task AddProduct(List<Product> products)
        {
            productRepository.Add(products);
            await this.unitOfWork.SaveChangesAsync();
        }
        public async Task DeleteProduct(Product product)
        {
            productRepository.Delete(product);
            await this.unitOfWork.SaveChangesAsync();
        }
        public async Task EditProduct(Product product)
        {
            productRepository.Edit(product);
            await this.unitOfWork.SaveChangesAsync();
        }
        public async Task<List<Product>> GetProducts()
        {
            return await productRepository.GetProducts().ConfigureAwait(false);
        }
    }
}
