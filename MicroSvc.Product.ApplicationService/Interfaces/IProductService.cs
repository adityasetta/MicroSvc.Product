namespace MicroSvc.Product.ApplicationService.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MicroSvc.Product.Domain.Entities;

    public interface IProductService
    {
        Task AddProduct(List<Product> products);
        Task DeleteProduct(Product product);
        Task EditProduct(Product product);
        Task<List<Product>> GetProducts();
    }
}
