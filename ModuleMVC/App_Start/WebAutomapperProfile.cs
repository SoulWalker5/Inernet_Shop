using AutoMapper;
using BL.BLModel;
using Module.Models;
using ModuleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module.App_Start
{
    public class WebAutomapperProfile : Profile
    {
        public WebAutomapperProfile()
        {
            CreateMap<CategoryModel, CategoryApiModel>().ReverseMap();
            CreateMap<ProductModel, ProductApiModel>()
                .ForMember(x => x.Category, y => y.MapFrom(x => x.Category))
                .ReverseMap();
        }
    }
}