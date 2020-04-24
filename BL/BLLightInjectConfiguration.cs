using DAL.Repository;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BLLightInjectConfiguration
    {
        public static ServiceContainer Configuration(ServiceContainer container)
        {
            container.Register(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return container;
        }
    }
}
