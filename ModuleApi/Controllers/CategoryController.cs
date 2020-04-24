using AutoMapper;
using BL.BLModel;
using BL.Service;
using ModuleApi.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ModuleApi.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ICategoryService _service;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Category
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var model = _service.GetAll();
            var apimodel = _mapper.Map<IEnumerable<CategoryApiModel>>(model);

            return Ok(apimodel);
        }

        // GET: api/Category/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var model = _service.FindById(id);
            var apimodel = _mapper.Map<CategoryApiModel>(model);

            return Ok(apimodel);
        }

        // POST: api/Category
        [HttpPost]
        public IHttpActionResult Post([FromBody] CategoryApiModel apiModel)
        {
            var articleBL = _mapper.Map<CategoryBL>(apiModel);
            _service.Create(articleBL);

            return Ok();
        }

        // PUT: api/Category/5
        [HttpPut]
        public IHttpActionResult Put([FromBody] CategoryApiModel apiModel)
        {
            var articleBL = _mapper.Map<CategoryBL>(apiModel);
            _service.Update(articleBL);

            return Ok();
        }

        // DELETE: api/Category/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _service.Remove(id);

            return Ok();
        }
    }
}
