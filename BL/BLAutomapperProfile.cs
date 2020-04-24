using AutoMapper;
using BL.BLModel;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLAutomapperProfile : Profile
    {
        public BLAutomapperProfile()
        {   
            CreateMap<CategoryBL, Category>()
                .ReverseMap();
            CreateMap<ProductBL, Product>()
                .ForMember(x => x.Category, y => y.MapFrom(x => x.CategoryBL))
                .ReverseMap();
        }
    }
}
