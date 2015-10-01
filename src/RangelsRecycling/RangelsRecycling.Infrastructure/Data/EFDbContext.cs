using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RangelsRecycling.Domain.Models;

namespace RangelsRecycling.Infrastructure.Data
{
    public class EFDbContext : DbContext
    {
        public DbSet<Material> Materials { get; set; }
    }
}
