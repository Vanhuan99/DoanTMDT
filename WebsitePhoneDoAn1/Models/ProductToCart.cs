using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsitePhoneDoAn1.Models.Domain;

namespace WebsitePhoneDoAn1.Models
{
    public class ProductToCart
    {
        public ProductModel ProductModel { get; set; }
        public int Quantity { get; set; }

        public Product Product;
    }
}
