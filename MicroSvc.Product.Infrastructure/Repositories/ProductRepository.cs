namespace MicroSvc.Product.Infrastructure.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using MicroSvc.Product.Domain.Entities;
    using MicroSvc.Product.Domain.Repositories;

    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly ProductContext productContext;

        public ProductRepository(ProductContext productContext) : base(productContext)
        {
            this.productContext = productContext;
        }

        public void Add(List<Product> products) => productContext.Product.AddRange(products);

        public void Delete(Product product) => productContext.Product.Remove(product);

        public void Edit(Product product) => productContext.Product.Update(product);

        public async Task<List<Product>> GetProducts() => await productContext.Product.ToListAsync().ConfigureAwait(false);
    }
}
