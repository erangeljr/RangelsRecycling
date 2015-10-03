using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RangelsRecycling.Domain.Abstract;

namespace RangelsRecycling.Web.Controllers
{
    public class MaterialController : Controller
    {
        //private IMaterialRepository _materialRepository;

        //public MaterialController(IMaterialRepository repository)
        //{
        //    _materialRepository = repository;
        //}

        public ActionResult ProcessMaterial()
        {
            return View();
        }

    }
}