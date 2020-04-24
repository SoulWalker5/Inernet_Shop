using Module.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModuleMVC.Models
{
    public class ProductsByCategoty
    {
        public IEnumerable<ProductModel> Products { get; set; }
        public SelectList Category { get; set; }
    }
}