using AutoMapper;
using BL.BLModel;
using BL.Service;
using ModuleApi.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ModuleApi.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductService _service;
        private readonly IMapper _mapper;
        public ProductController(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Product
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var model = _service.GetAll();
            var apimodel = _mapper.Map<IEnumerable<ProductApiModel>>(model);

            return Ok(apimodel);
        }

        // GET: api/Product/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var model = _service.FindById(id);
            var apimodel = _mapper.Map<ProductApiModel>(model);

            return Ok(apimodel);
        }

        // POST: api/Product
        [HttpPost]
        public IHttpActionResult Post([FromBody] ProductApiModel apiModel)
        {
            var articleBL = _mapper.Map<ProductBL>(apiModel);
            _service.Create(articleBL);

            return Ok();
        }

        // PUT: api/Product/5
        [HttpPut]
        public IHttpActionResult Put([FromBody] ProductApiModel apiModel)
        {
            var articleBL = _mapper.Map<ProductBL>(apiModel);
            _service.Update(articleBL);

            return Ok();
        }

        // DELETE: api/Product/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _service.Remove(id);

            return Ok();
        }
    }
}
