using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsitePhoneDoAn1.Models
{
    public class ProductData
    {
        public List<ProductModel> ProductList { get; set; }

        public static ProductData initData()
        {
            List<ProductModel> products = new List<ProductModel>();
            products.AddRange(new List<ProductModel>
            {

                new ProductModel()
                {
                    ProductName = "Iphone X",
                    ProductImage = "iphoneX.png",
                    Descriptions = "Iphone X 64GB - 256GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.0,
                    CreateDate = DateTime.Now
                },

                  new ProductModel()
                {
                    ProductName = "Iphone 11",
                    ProductImage = "ip11.jpg",
                    Descriptions = "Iphone 11 64GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.0,
                    CreateDate = DateTime.Now
                },

                  new ProductModel()
                {
                    ProductName = "Iphone X",
                    ProductImage = "ip7plus.png",
                    Descriptions = "Iphone X 64GB - 256GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.0,
                    CreateDate = DateTime.Now
                },

                      new ProductModel()
                {
                    ProductName = "Iphone 11",
                    ProductImage = "ip8plus.png",
                    Descriptions = "Iphone 11 64GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.0,
                    CreateDate = DateTime.Now
                },

                  new ProductModel()
                {
                    ProductName = "Iphone X",
                    ProductImage = "111.png",
                    Descriptions = "Iphone X 64GB - 256GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.0,
                    CreateDate = DateTime.Now
                },





            });
            return new ProductData()
            {
                ProductList = products
            };

        }


    }
}
