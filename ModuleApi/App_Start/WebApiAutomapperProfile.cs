using AutoMapper;
using BL.BLModel;
using ModuleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuleApi.App_Start
{
    public class WebApiAutomapperProfile : Profile
    {
        public WebApiAutomapperProfile()
        {
            CreateMap<CategoryApiModel, CategoryBL>().ReverseMap();
            CreateMap<ProductApiModel, ProductBL>().ForMember(x => x.CategoryBL, y => y.MapFrom(x => x.Category)).ReverseMap();
        }
    }
}