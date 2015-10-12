using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RangelsRecycling.Domain.Abstract;
using RangelsRecycling.Domain.Models;
using RangelsRecycling.Web.Controllers;
using RangelsRecycling.Web.Models;

namespace RangelsRecycling.Tests.Controllers
{
    [TestClass]
    public class MaterialControllerTest
    {
        [TestMethod]
        public void Can_Viw_Model()
        {
            Mock<IMaterialRepository> mock = new Mock<IMaterialRepository>();
            mock.Setup(m => m.Materials).Returns(new Material[]
            {
                new Material {MaterialId = 1, Name = "Aluminum"},
                new Material {MaterialId = 1, Name = "Glass"},
                new Material {MaterialId = 1, Name = "Bi-Metal"},
                new Material {MaterialId = 1, Name = "#1 PET Plastic", Description = "Polyethylene Terephthalate"},
            });

            MaterialController controller = new MaterialController(mock.Object);
            MaterialsListViewModel result = (MaterialsListViewModel) controller.List().Model;

            Assert.AreEqual(4, result.Materials.Count());
        }
    }
}
