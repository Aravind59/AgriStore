using AgriStore.Contracts.Interfaces;
using AgriStore.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using Unity.Lifetime;

namespace AgriStore.DependencyResolver
{
    public static class SetupUnityContainerHelper
    {
      
        public static UnityContainer SetUpUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IProductService, ProductService>(new HierarchicalLifetimeManager());

            return container;
        }
    }
}