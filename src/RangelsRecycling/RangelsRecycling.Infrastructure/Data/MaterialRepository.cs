using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RangelsRecycling.Domain.Abstract;
using RangelsRecycling.Domain.Models;

namespace RangelsRecycling.Infrastructure.Data
{
    public class MaterialRepository : IMaterialRepository
    {

        private EFDbContext context = new EFDbContext();

        public IEnumerable<Material> Materials
        {
            get { return context.Materials; }
        }
    }
}
