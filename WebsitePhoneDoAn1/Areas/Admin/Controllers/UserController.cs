using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebsitePhoneDoAn1.Data;
using WebsitePhoneDoAn1.Models;

namespace WebsitePhoneDoAn1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class UserController : Controller
    {
        DataContext dataContext;
        public UserController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public IActionResult Index()
        {
            var user = dataContext.Users.ToList();
            return View(user);
        }
        //[HttpGet]
        //public IActionResult Add()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Add(IdentityUser user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        IdentityUser identityUser = new IdentityUser();
        //        identityUser.UserName = user.UserName;
        //        identityUser.Email = user.Email;
        //        identityUser.PasswordHash = user.PasswordHash;
        //        db.Users.Add((Models.User)identityUser);
        //        db.SaveChanges();
        //        RedirectToAction("Index", "User");
        //    }
        //    return View(user);
        //}
       
    }
}