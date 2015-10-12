using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RangelsRecycling.Domain.Models;

namespace RangelsRecycling.Web.Models
{
    public class MaterialsListViewModel
    {
        public IEnumerable<Material> Materials { get; set; }
    }
}