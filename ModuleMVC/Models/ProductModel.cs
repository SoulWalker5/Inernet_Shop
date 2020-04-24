using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Module.Models
{
    //[DataContract(IsReference = true)]
    public class ProductModel
    {
        //[DataMember]
        public int Id { get; set; }
        //[DataMember]
        public int Number { get; set; }
        //[DataMember]
        public string Name { get; set; }

        //[DataMember]
        public int CategoryId { get; set; }

        //[DataMember]
        public CategoryModel Category { get; set; }
    }
}