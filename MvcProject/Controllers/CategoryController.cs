﻿using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryValues = cm.GetAllBL();
            return View(categoryValues);

        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            cm.CategoryAddBL(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}