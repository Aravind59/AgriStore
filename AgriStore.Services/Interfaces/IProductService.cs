using AgriStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriStore.Contracts.Interfaces
{
   public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}
