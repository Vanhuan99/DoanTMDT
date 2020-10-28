using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebsitePhoneDoAn1.Data;
using WebsitePhoneDoAn1.Models;
using WebsitePhoneDoAn1.Models.Domain;

namespace WebsitePhoneDoAn1.Controllers
{
    public class HomeController : Controller
    {
      

            DataContext dataContext;
            IMapper mapper;

            public HomeController(DataContext dataContext, IMapper mapper)
            {
                this.dataContext = dataContext;
                this.mapper = mapper;
            }

            public IActionResult Index()
            {
                List<Category> categories = dataContext.Categories.ToList();
                ViewBag.CategoryList = categories;
                List<ProductModel> products = new List<ProductModel>();
                List<Product> products1 = dataContext.Products.ToList();
                foreach (var item in products1)
                {
                    ProductModel p = new ProductModel()
                    {
                        ProductId = item.ProductId,
                        ProductName = item.ProductName,
                        Descriptions = item.Descriptions,
                        ProductQuantity = item.ProductQuantity,
                        ProductPrice = item.ProductPrice,
                        ProductImage = item.ProductImage,
                        CreateDate = item.CreateDate,
                    };
                    products.Add(p);
                    dataContext.SaveChanges();
                }
                return View(products);

                //List<ProductModel> products = new List<ProductModel>();
                //List<Product> products1 = dataContext.Products.ToList();
                //foreach (var item in products1)
                //{
                //    products.Add(mapper.Map<ProductModel>(item));
                //}
                //return View(products);


                //return View(data.ProductList);
            }
           
            public IActionResult GioiThieu()
            {
                return View();
            }
            public IActionResult LienHe()
            {
                return View();
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
