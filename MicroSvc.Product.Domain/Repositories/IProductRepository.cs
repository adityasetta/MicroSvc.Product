namespace MicroSvc.Product.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MicroSvc.Product.Domain.Entities;

    public interface IProductRepository : IRepository<Product>
    {
        void Add(List<Product> products);
        void Delete(Product product);
        void Edit(Product product);
        Task<List<Product>> GetProducts();
    }
}
