using AutoMapper;
using Module.Models;
using ModuleMVC.Models;
using ModuleMVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ModuleMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiService _prodService;
        private readonly ICategoryApiService _catService;

        public ProductController()
        {
            _prodService = new ProductService();
            _catService = new CategoryService();
        }
        // GET: Product
        public ActionResult Index()
        {
            var response =_prodService.GetProducts();

            return View(response);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var response = _prodService.FindById(id);

            return View(response);
        }

        public ActionResult ProdByCat(int? categoryID)
        {
            var products = _prodService.GetProducts();

            if (categoryID != 0)
            {
                products = products.Where(x => x.Category.Id == categoryID);
            }

            var categories = _catService.GetCategories();

            ProductsByCategoty productsList = new ProductsByCategoty
            {
                Products = products,
                Category = new SelectList(categories, "Id", "Name ")
            };

            return View(productsList);
        }
    }
}
