using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebsitePhoneDoAn1.Models;
using static WebsitePhoneDoAn1.Models.ListIdentityUser;

namespace WebsitePhoneDoAn1.Controllers
{
    public class AccountController : Controller
    {

        private readonly IMapper _mapper;
        private readonly SignInManager<User> _SinInManager;
        private readonly UserManager<User> _userManager;

        public AccountController(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _SinInManager = signInManager;
        }
       
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            UserRegistrationModel userRegistrationModel = new UserRegistrationModel();
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Register(UserRegistrationModel model, string returnUrl = null)
        {

            if (ModelState.IsValid)/*Phần đăng ký cho User*/
            {
                //var user = _mapper.Map<User>(model);
                // Copy data from RegisterViewModel to IdentityUser
                var user = new User
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                // Store user data in AspNetUsers database table
                var result = await _userManager.CreateAsync(user, model.Password);

           
                if (result.Succeeded)
                {
                    await _SinInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

       
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                await _userManager.AddToRoleAsync(user, "Visitor");
            }
            return View(model);    
        }
        private async Task AddRoleUser(RoleType type, User user)
        {
            switch (type)
            {
                case RoleType.Admin:
                    await _userManager.AddToRoleAsync(user, "Admin");
                    break;
                case RoleType.User:
                    await _userManager.AddToRoleAsync(user, "User");
                    break;
                case RoleType.HR:
                    await _userManager.AddToRoleAsync(user, "HR");
                    break;
            }
        }
        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        [HttpGet]

        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(UserLoginModel userModel, string returnUrl = null)
        {
            if (!ModelState.IsValid) { return View(userModel); }

            var result = await _SinInManager.PasswordSignInAsync(userModel.Email, userModel.Password, userModel.RememberMe, false);

            if (result.Succeeded)
            {

                return RedirectToLocal(returnUrl);
            }
            else
            {
                ModelState.AddModelError("", "Invalid UserName or Password"); return View();
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _SinInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            else
                return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
