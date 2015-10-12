using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moq;
using Ninject;
using RangelsRecycling.Domain.Abstract;
using RangelsRecycling.Domain.Models;
using RangelsRecycling.Infrastructure;
using RangelsRecycling.Infrastructure.Data;

namespace RangelsRecycling.Web.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
            AddBindings();
        }

        private void AddBindings()
        {
            //Adding Bindings
            //Mock<IMaterialRepository> mock = new Mock<IMaterialRepository>();
            //mock.Setup(m => m.Materials).Returns(new List<Material>
            //{
            //    new Material { MaterialId = 1, Name = "Aluminum", Description = "Aluminum Desc"},
            //    new Material { MaterialId = 2, Name = "Glass", Description = "Glass Desc"},
            //    new Material { MaterialId = 1, Name = "#1", Description = "#1 PET Desc"},
            //});
            //_kernel.Bind<IMaterialRepository>().ToConstant(mock.Object);
            _kernel.Bind<IMaterialRepository>().To<MaterialRepository>();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
    }
}