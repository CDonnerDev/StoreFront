using System;
using System.Collections.Generic;

namespace StoreFront.UI.MVC.Models
{
    public partial class ProductStatus
    {
        public ProductStatus()
        {
            Products = new HashSet<Product>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; } = null!;
        public string StatusDescription { get; set; } = null!;
        public bool Discontinued { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
