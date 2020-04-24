using AutoMapper;
using BL.BLModel;
using DAL.Entity;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Service
{
    public interface ICategoryService : IGenericService<CategoryBL>
    {

    }
    public class CategoryService : GenericService<CategoryBL, Category>, ICategoryService
    {
        private readonly IMapper _mapper;
        public CategoryService(IGenericRepository<Category> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override CategoryBL Map(Category entity)
        {
            return _mapper.Map<CategoryBL>(entity);

        }

        public override Category Map(CategoryBL blmodel)
        {
            return _mapper.Map<Category>(blmodel);
        }

        public override IEnumerable<CategoryBL> Map(IList<Category> entitiesList)
        {
            return _mapper.Map<IEnumerable<CategoryBL>>(entitiesList);
        }

        public override IEnumerable<Category> Map(IList<CategoryBL> entitiesList)
        {
            return _mapper.Map<IEnumerable<Category>>(entitiesList);
        }
    }
}
