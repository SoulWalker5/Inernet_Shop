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
    public interface IProductService : IGenericService<ProductBL>
    {

    }
    public class ProductService : GenericService<ProductBL, Product>, IProductService
    {
        private readonly IMapper _mapper;
        public ProductService(IGenericRepository<Product> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override ProductBL Map(Product entity)
        {
            return _mapper.Map<ProductBL>(entity);
        }

        public override Product Map(ProductBL blmodel)
        {
            return _mapper.Map<Product>(blmodel);
        }

        public override IEnumerable<ProductBL> Map(IList<Product> entitiesList)
        {
            return _mapper.Map<IEnumerable<ProductBL>>(entitiesList);

        }

        public override IEnumerable<Product> Map(IList<ProductBL> entitiesList)
        {
            return _mapper.Map<IEnumerable<Product>>(entitiesList);

        }
    }
}
