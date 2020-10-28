using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebsitePhoneDoAn1.Data;
using WebsitePhoneDoAn1.Models;
using WebsitePhoneDoAn1.Models.Domain;

namespace WebsitePhoneDoAn1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class ProductController : Controller
    {
        ProductData productData;
        DataContext dataContext;
        IMapper mapper;
        public ProductController(ProductData productData, DataContext dataContext, IMapper mapper)
        {
            this.productData = productData;
            this.dataContext = dataContext;
            this.mapper = mapper;

        }
        [HttpGet]
        public IActionResult Index()
        {
             List<ProductModel> products = new List<ProductModel>();
            List<Product> productss =dataContext.Products.ToList();
            foreach (Product p in productss)
            {
                //products.Add(mapper.Map<ProductModel>(item));
                //ProductModel p = new ProductModel()
                products.Add(new ProductModel()
                {              
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    Descriptions = p.Descriptions,
                    ProductImage = p.ProductImage,
                    ProductQuantity = p.ProductQuantity,
                    ProductPrice = p.ProductPrice,
                    CategoryId = 1,
                    CreateDate=p.CreateDate
                });
            }
            return View(products);
        }
        [HttpGet]
        public IActionResult Add()
        {
            Product product = new Product();
            var a = (from p in dataContext.Categories select p).ToList();
            ViewBag.Category = a;
            ViewBag.Selected = new SelectList(a, "CategoryId", "CategoryName");
            ProductModel productModel = new ProductModel();
            return View(product);
        }
        [HttpPost]
        public IActionResult Add(Product product, IFormFile photo)
        {
            if (ModelState.IsValid)
            {
                Product newProduct = new Product();

                if (photo == null || photo.Length == 0)
                {
                    newProduct.ProductImage = "maintain.jpg";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo.CopyToAsync(stream);
                    newProduct.ProductImage = photo.FileName;
                }
                newProduct.ProductName = product.ProductName;
                newProduct.Descriptions = product.Descriptions;
                newProduct.ProductQuantity = product.ProductQuantity;
                newProduct.ProductPrice = product.ProductPrice;
                newProduct.CreateDate = DateTime.Now;
                newProduct.CategoryId = product.CategoryId;

                dataContext.Products.Add(newProduct);
                dataContext.SaveChanges();
                return RedirectToAction("Index", "Product");
            }
            else
            {
                var a = (from p in dataContext.Categories select p).ToList();
                ViewBag.Selected = new SelectList(a, "CategoryId", "CategoryName");
                return View(product);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product product = new Product();
            var pr = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            var a = (from p in dataContext.Categories select p).ToList();
            ViewBag.Category = a;
            ViewBag.Selected = new SelectList(a, "CategoryId", "CategoryName");

            return View(pr);

            //Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            //ProductModel oldProduct = new ProductModel()
            //{
            //    ProductId = product.ProductId,
            //    ProductName = product.ProductName,
            //    Descriptions=product.Descriptions,
            //    ProductQuantity=product.ProductQuantity,
            //    ProductPrice=product.ProductPrice
            //};
            //return View(oldProduct);
        }
        [HttpPost]
        public IActionResult Edit(int id, Product product)
        {
            if (ModelState.IsValid)
            {
                Product oldProduct = dataContext.Products.Include(m => m.Category).FirstOrDefault(p => p.ProductId == id);
                oldProduct.ProductName = product.ProductName;
                oldProduct.Descriptions = product.Descriptions;
                oldProduct.ProductQuantity = product.ProductQuantity;
                oldProduct.ProductPrice = product.ProductPrice;
                oldProduct.CreateDate = DateTime.Now;

                //Product p = dataContext.Products.Include(m => m.CategoryId).FirstOrDefault(p => p.ProductId == id);
                //p.ProductName = product.ProductName;
                //p.Descriptions = product.Descriptions;
                //p.ProductQuantity = product.ProductQuantity;
                //p.ProductPrice = product.ProductPrice;
                //p.CategoryId = product.CategoryId;
                dataContext.SaveChanges();
                ViewBag.Status = 1;
            }
            var a = (from p in dataContext.Categories select p).ToList();
            ViewBag.Selected = new SelectList(a, "CategoryId", "CategoryName");
            return View(product);
        }
        public IActionResult Delete(int id)
        {

            Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            ProductModel oldProduct = new ProductModel()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName
            };

            return View(oldProduct);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            //productData.ProductList.RemoveAll(p => p.ProductId == id);
            //return RedirectToAction("Index", "Product");
            Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            dataContext.Products.Remove(product);
            dataContext.SaveChanges();
            return RedirectToAction("Index", "Product");
        }

    }
}