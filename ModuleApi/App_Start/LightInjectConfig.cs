using AutoMapper;
using BL;
using BL.Service;
using LightInject;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Http;

namespace ModuleApi.App_Start
{
    public static class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();
            container.RegisterApiControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                  new List<Profile>() { new WebApiAutomapperProfile(), new BLAutomapperProfile() }));

            container.Register(c => config.CreateMapper());

            container = BLLightInjectConfiguration.Configuration(container);

            container.Register<ICategoryService, CategoryService>();
            container.Register<IProductService, ProductService>();


            container.EnableWebApi(GlobalConfiguration.Configuration);
        }
    }
}