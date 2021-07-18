using AgriStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriStore.Repositories
{
   public class AgriStoreDbContext: DbContext
    {
        public AgriStoreDbContext():base("name=AgriStoreDb")
        {
            Database.SetInitializer<AgriStoreDbContext>(null);
        }
              
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<SubProductType> SubProductTypes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<QuantityType> QuantityTypes { get; set; }
     
    }
}
