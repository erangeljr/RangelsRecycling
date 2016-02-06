using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RangelsRecycling.Domain.Abstract;
using RangelsRecycling.Domain.Models;
using RangelsRecycling.Web.Models;

namespace RangelsRecycling.Web.Controllers
{
    public class MaterialController : Controller
    {
        private IMaterialRepository _materialRepository;

        public MaterialController(IMaterialRepository repository)
        {
            _materialRepository = repository;
        }

        public ViewResult List()
        {
            MaterialsListViewModel model = new MaterialsListViewModel
            {
                Materials = _materialRepository.Materials.OrderBy(m => m.MaterialId)
            };
            return View(model);
        }

        public ActionResult ProcessMaterial()
        {
            return View();
        }

    }
}