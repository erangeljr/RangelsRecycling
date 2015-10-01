using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RangelsRecycling.Domain.Models;

namespace RangelsRecycling.Domain.Abstract
{
    public interface IMaterialRepository
    {
        IEnumerable<Material> Materials { get; }
    }
}
