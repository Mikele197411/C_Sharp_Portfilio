using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiViewModel.Models
{
   public class Reservations
    {
        public string OfferUId { get; set; }
        public Customer Customer { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class Booking
    {
        public string СonfirmationNumber { get; set; }
      
    }
}

