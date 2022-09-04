using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_ASP.Models.Entities
{
    public class Offer
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }
        public ICollection<TravelAgencyOffer> TravelAgencyOffers { get; set; } 
           
    }
}
