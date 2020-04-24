using AutoMapper;
using Module.Models;
using ModuleApi.Models;
using RestSharp;
using RestSharp.Serialization.Json;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuleMVC.Service
{
    public interface ICategoryApiService
    {
        IEnumerable<CategoryModel> Remove(int id);
        IEnumerable<CategoryModel> Update(CategoryModel model);
        CategoryModel FindById(int id);
        IEnumerable<CategoryModel> GetCategories();
    }
    public class CategoryService : ICategoryApiService
    {
        private readonly RestClient _rest;
        //private readonly IMapper _mapper;

        public CategoryService()
        {
            _rest = new RestClient("http://local.module:81");
            //_mapper = mapper;
        }

        //public CategoryModel Create(CategoryModel model)
        //{

        //    var url = "api/Category";
        //    var req = new RestRequest(url, Method.POST);
        //    var response = _rest.ExecuteAsPost<CategoryModel>(req, "POST").Data;

        //    return response;
        //}

        public CategoryModel FindById(int id)
        {
            var url = $"api/Category/{id}";
            var req = new RestRequest(url);
            var response = _rest.Execute<CategoryModel>(req, Method.GET).Data;

            return response;
        }

        public IEnumerable<CategoryModel> GetCategories()
        {
            var url = "api/Category";
            var req = new RestRequest(url);
            var response = _rest.Execute<IEnumerable<CategoryModel>>(req, Method.GET).Data;

            return response;
        }

        public IEnumerable<CategoryModel> Remove(int id)
        {
            var url = $"api/Category/{id}";
            var req = new RestRequest(url);
            var response = _rest.Execute<IEnumerable<CategoryModel>>(req, Method.DELETE).Data;

            return response;
        }

        public IEnumerable<CategoryModel> Update(CategoryModel model)
        {
            var url = $"api/Category/{model.Id}";
            var req = new RestRequest(url);
            var response = _rest.Execute<IEnumerable<CategoryModel>>(req, Method.PUT).Data;

            return response;
        }
    }
}