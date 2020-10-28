using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebsitePhoneDoAn1.Data;
using WebsitePhoneDoAn1.Models;
using WebsitePhoneDoAn1.Models.Domain;

namespace WebsitePhoneDoAn1.Controllers
{
    public class DetailController : Controller
    {

        private DataContext dataContext;
        public DetailController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet("Detail/{id}/{name}")]
        public IActionResult Index(int id)
        {
            //ProductModel productModel = productData.ProductList.FirstOrDefault(p => p.ProductId == id);
            Product product = dataContext.Products.Include(x => x.Category).FirstOrDefault(p => p.ProductId == id);
            ProductModel productModel = new ProductModel()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
                Descriptions = product.Descriptions,
                ProductImage = product.ProductImage
            };
            var prt = dataContext.Products.Find(id);
            var ds = dataContext.Products.Where(x => x.CategoryId == prt.CategoryId && x.ProductId != id).ToList();
            ViewBag.ds = ds;
            return View(productModel);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}