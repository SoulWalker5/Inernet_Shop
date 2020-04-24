using AutoMapper;
using Module.Models;
using ModuleMVC.Service;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModuleMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryApiService _apiService;
        //private readonly IMapper _mapper;

        public CategoryController()
        {
            _apiService = new CategoryService();
        }
        // GET: Category
        public ActionResult Index()
        {
            var response = _apiService.GetCategories();

            return View(response);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            var response = _apiService.FindById(id);

            return View(response);
        }

        // GET: Category/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Category/Create
        //[HttpPost]
        //public ActionResult Create(CategoryModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    _apiService.Create(model);

        //    return RedirectToAction("Index");
        //}

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
