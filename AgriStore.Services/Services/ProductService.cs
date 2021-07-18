using AgriStore.Contracts.Interfaces;
using AgriStore.Models.Models;
using AgriStore.Repositories.DAL;
using System.Collections.Generic;

namespace AgriStore.Services.Services
{
    public class ProductService: IProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService()
        {
            _repository = new Repository<Product>();
        }
        public IEnumerable<Product> GetProducts()
        {
            return _repository.GetAll();
        }
    }
}
