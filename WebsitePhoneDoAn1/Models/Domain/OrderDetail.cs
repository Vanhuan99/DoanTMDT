using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsitePhoneDoAn1.Models.Domain
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public Product Product { get; set; }
    }
}
