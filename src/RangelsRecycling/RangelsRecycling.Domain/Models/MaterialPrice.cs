using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace RangelsRecycling.Domain.Models
{
    public class MaterialPrice
    {
        public int MaterialPriceId { get; set; }
        public decimal CrvRate { get; set; }
        public decimal ScrapRate { get; set; }
        public DateTime MaterialPriceDate { get; set; }
    }
}
