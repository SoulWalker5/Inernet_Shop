using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuleApi.Models
{
    public class CategoryApiModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }

        public IEnumerable<ProductApiModel> Products { get; set; }
    }
}