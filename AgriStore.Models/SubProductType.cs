using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriStore.Models.Models
{
   public class SubProductType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ProductTypeId { get; set; }
    }
}
