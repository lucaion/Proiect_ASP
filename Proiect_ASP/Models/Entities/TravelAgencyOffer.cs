using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_ASP.Models.Entities
{
    public class TravelAgencyOffer
    {
        public int TravelAgencyId { get; set; }
        public TravelAgency TravelAgency { get; set; }
        public int OfferId { get; set; }
        public Offer Offer { get; set; }
    }
}
