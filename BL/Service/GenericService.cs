using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Service
{
    public interface IGenericService<BLModel> where BLModel : class
    {
        BLModel FindById(int id);
        IEnumerable<BLModel> GetAll();
        void Create(BLModel item);
        void Update(BLModel item);
        void Remove(int id);
    }
    public abstract class GenericService<BLModel, DModel> : IGenericService<BLModel>
        where BLModel : class
        where DModel : class
    {
        private readonly IGenericRepository<DModel> _repository;

        public GenericService(IGenericRepository<DModel> repository)
        {
            _repository = repository;
        }

        public void Create(BLModel item)
        {
            var entity = Map(item);
            _repository.Create(entity);
        }

        public BLModel FindById(int id)
        {
            var entity = _repository.FindById(id);

            return Map(entity);
        }

        public IEnumerable<BLModel> GetAll()
        {
            var listEntity = _repository.GetAll().ToList();

            return Map(listEntity);
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Update(BLModel item)
        {
            var model = Map(item);
            _repository.Update(model);
        }
        public abstract BLModel Map(DModel entity);
        public abstract DModel Map(BLModel blmodel);
        public abstract IEnumerable<BLModel> Map(IList<DModel> entity);
        public abstract IEnumerable<DModel> Map(IList<BLModel> entity);
    }
}
