using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuleApi.Models
{
    public class ProductApiModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public CategoryApiModel Category { get; set; }
    }
}