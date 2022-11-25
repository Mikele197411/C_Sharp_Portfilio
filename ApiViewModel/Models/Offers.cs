using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiViewModel.Models
{
    public class Offers
    {
        public string OfferUId { get; set; }
        public Vehicle Vehicle { get; set; }

        public Price Price { get; set; }
        public Vendor Vendor { get; set; }
    }

    public class Vendor
    {
        public string Name { get; set; }
        public string ImageLink { get; set; }
    }

    public class Price
    {
        public string Currency { get; set; }
        public decimal Amount { get; set; }
    }

    public class Vehicle
    {
        public string ModelName { get; set; }
        public string Sipp { get; set; }
        public string ImageLink { get; set; }
    }


  
}
