using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebsitePhoneDoAn1.Data;
using WebsitePhoneDoAn1.Helper;
using WebsitePhoneDoAn1.Models;
using WebsitePhoneDoAn1.Models.Domain;

namespace WebsitePhoneDoAn1.Controllers
{
    public class CartController : Controller
    {
        private readonly DataContext dataContext;
        public CartController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public IActionResult Index()
        {
            //var cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            //ViewBag.cart = cart;
            //ViewBag.total = cart.Sum(item => item.Product.ProductPrice * item.Quantity);
            //return View();
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            if (cart != null && cart.Any())
            {
                ViewBag.cart = cart;
                ViewBag.total = cart.Sum(item => item.Product.ProductPrice * item.Quantity);
            }

            return View();
        }

        [Route("buy/{id}")]
        public IActionResult Buy(int id)
        {

            if (SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart") == null)
            {
                List<ProductToCart> cart = new List<ProductToCart>();
                cart.Add(new ProductToCart { Product = dataContext.Products.FirstOrDefault(p => p.ProductId == id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new ProductToCart { Product = dataContext.Products.FirstOrDefault(p => p.ProductId == id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }

        [Route("remove/{id}")]

        public IActionResult Remove(int id)
        {
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        private int isExist(int id)
        {
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductId == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public IActionResult XacNhan(string Name, string sdt, string Email)
        {
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.ProductPrice * item.Quantity);

            Order order = new Order()
            {
                OrderDate = DateTime.Now
            };
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            dataContext.Orders.Add(order);
            dataContext.SaveChanges();
            foreach (ProductToCart item in cart)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    OrderId = order.OrderId,
                    ProductId = item.Product.ProductId,
                    Quantity = item.Quantity,
                    Name = Name,
                    Email = Email,
                    Sdt = sdt
                };
                dataContext.OrderDetails.Add(orderDetail);
                dataContext.SaveChanges();
            }
            return View();
        }

    }
}

