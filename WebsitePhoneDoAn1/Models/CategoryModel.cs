using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebsitePhoneDoAn1.Models
{
    public class CategoryModel
    {
        public int CategoryID { get; set; }
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
    }
}
