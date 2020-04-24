using Module.Models;
using ModuleApi.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuleMVC.Service
{
    public interface IProductApiService
    {
        ProductApiModel Create(ProductModel model);
        IEnumerable<ProductModel> Remove(int id);
        IEnumerable<ProductModel> Update(ProductModel model);
        ProductModel FindById(int id);
        IEnumerable<ProductModel> GetProducts();
    }

    public class ProductService : IProductApiService
    {
        private readonly RestClient _rest;

        public ProductService()
        {
            _rest = new RestClient("http://local.module:81");
        }

        public ProductApiModel Create(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public ProductModel FindById(int id)
        {
            var url = $"api/Product/{id}";
            var req = new RestRequest(url);
            var response = _rest.Execute<ProductModel>(req, Method.GET).Data;

            return response;
        }

        public IEnumerable<ProductModel> GetProducts()
        {
            var url = "api/Product";
            var req = new RestRequest(url);
            var response = _rest.Execute<IEnumerable<ProductModel>>(req, Method.GET).Data;

            return response;
        }

        public IEnumerable<ProductModel> Remove(int id)
        {
            var url = $"api/Product/{id}";
            var req = new RestRequest(url);
            var response = _rest.Execute<IEnumerable<ProductModel>>(req, Method.DELETE).Data;

            return response;    
        }

        public IEnumerable<ProductModel> Update(ProductModel model)
        {
            var url = $"api/Product/{model.Id}";
            var req = new RestRequest(url);
            var response = _rest.Execute<IEnumerable<ProductModel>>(req, Method.PUT).Data;

            return response;
        }
    }
}