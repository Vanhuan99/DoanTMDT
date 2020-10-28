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
    public class CategoryController : Controller
    {
        DataContext dataContext;
        public CategoryController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<CategoryModel> categoryModels = new List<CategoryModel>();
            List<Category> categories = dataContext.Categories.ToList();
            foreach (var item in categories)
            {
                CategoryModel c = new CategoryModel()
                {
                    CategoryID = item.CategoryId,
                    CategoryName = item.CategoryName,
                };
                categoryModels.Add(c);
            }
            return View(categoryModels);
        }

        //Thêm
        [HttpGet]
        public IActionResult Add()
        {
            CategoryModel categoryModel = new CategoryModel();
            return View(categoryModel);
        }
        [HttpPost]
        public IActionResult Add(CategoryModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                CategoryModel newCategory = new CategoryModel();
                newCategory.CategoryName = categoryModel.CategoryName;
                // productData.ProductList.Add(newProduct);
                Category c = new Category()
                {
                    CategoryName = newCategory.CategoryName,
                };
                dataContext.Categories.Add(c);
                dataContext.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            else
            {
                return View(categoryModel);
            }
        }

        //Sửa
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Category category = dataContext.Categories.FirstOrDefault(p => p.CategoryId == id);
            CategoryModel oldCategory = new CategoryModel()
            {
                CategoryID = category.CategoryId,
                CategoryName = category.CategoryName,
            };
            return View(oldCategory);
        }
        [HttpPost]
        public IActionResult Edit(int id, CategoryModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                Category c = dataContext.Categories.FirstOrDefault(p => p.CategoryId == id);
                c.CategoryName = categoryModel.CategoryName;
                dataContext.SaveChanges();
                ViewBag.Status = 1;
            }
            return View(categoryModel);
        }

        //Xóa
        public IActionResult Delete(int id)
        {
            Category category = dataContext.Categories.FirstOrDefault(p => p.CategoryId == id);
            CategoryModel oldCategory = new CategoryModel()
            {
                CategoryID = category.CategoryId,
                CategoryName = category.CategoryName
            };

            return View(oldCategory);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Category category = dataContext.Categories.FirstOrDefault(p => p.CategoryId == id);
            dataContext.Categories.Remove(category);
            dataContext.SaveChanges();
            return RedirectToAction("Index", "Category");
        }
    }
}