using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebsitePhoneDoAn1.Data;
using WebsitePhoneDoAn1.Models;
using WebsitePhoneDoAn1.Models.Domain;

namespace WebsitePhoneDoAn1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class QLDHController : Controller
    {
        DataContext dataContext;
        public QLDHController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<OrderDetail> OrderDetail = new List<OrderDetail>();
            List<OrderDetail> OrderDetails = dataContext.OrderDetails.ToList();
            foreach (var item in OrderDetail)
            {
                
                OrderDetail.Add(new OrderDetail()
                {
                   OrderDetailId = item.OrderDetailId,
                   OrderId = item.OrderId,
                   ProductId = item.ProductId,
                   Quantity = item.Quantity,
                   Name = item.Name,
                   Email = item.Email,
                   Sdt = item.Sdt
                });
            }
            return View(OrderDetails);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
           OrderDetail orderDetail = dataContext.OrderDetails.FirstOrDefault(p => p.OrderDetailId == id);
            OrderDetail oldorderDetail = new OrderDetail()
            {
                OrderDetailId = orderDetail.OrderDetailId,
                OrderId = orderDetail.OrderId,
                ProductId = orderDetail.ProductId,
                Quantity = orderDetail.Quantity,
                Name = orderDetail.Name,
                Email = orderDetail.Email,
                Sdt = orderDetail.Sdt
            };
            return View(orderDetail);
        }
        [HttpPost]
        public IActionResult Edit(int id, OrderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                OrderDetail o = dataContext.OrderDetails.FirstOrDefault(p => p.OrderDetailId == id);
                o.OrderDetailId = orderDetail.OrderDetailId;
                o.OrderId = orderDetail.OrderId;
                o.ProductId = orderDetail.ProductId;
                o.Quantity = orderDetail.Quantity;
                o.Name = orderDetail.Name;
                o.Email = orderDetail.Email;
                o.Sdt = orderDetail.Sdt;
                dataContext.SaveChanges();
                ViewBag.Status = 1;
            }
            return View(orderDetail);
        }

        public IActionResult Delete(int id)
        {
            OrderDetail orderDetail = dataContext.OrderDetails.FirstOrDefault(p => p.OrderDetailId == id);
            OrderDetail oldOrderDetail = new OrderDetail()
            {
                OrderDetailId = orderDetail.OrderDetailId,
                OrderId = orderDetail.OrderId,
                ProductId = orderDetail.ProductId,
                Quantity = orderDetail.Quantity,
                Name = orderDetail.Name,
                Email = orderDetail.Email,
                Sdt = orderDetail.Sdt
               
            };

            return View(oldOrderDetail);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            OrderDetail orderDetail = dataContext.OrderDetails.FirstOrDefault(p => p.OrderDetailId == id);
            dataContext.OrderDetails.Remove(orderDetail);
            dataContext.SaveChanges();
            return RedirectToAction("Index", "QLDH");
        }
    }
}