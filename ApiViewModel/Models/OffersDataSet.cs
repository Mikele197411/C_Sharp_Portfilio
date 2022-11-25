using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiViewModel.Models
{
    public class OffersDataSet
    {
        public string OfferUId { get; set; }
        public string ModelName { get; set; }
        public Decimal Price { get; set; }
        public string Currency { get; set; }
        public string VendorName { get; set; }
       
    }
}
