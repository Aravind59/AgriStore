using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriStore.Models.Models
{
   public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public decimal Price { get; set; }
        public decimal NetQuantity { get; set; }
        public Guid SubProductTypeId { get; set; }
        public Guid? QuantityTypeId { get; set; }
        public Guid? BrandId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        //[ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

    }
}
