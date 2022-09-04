using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_ASP.Models.Entities
{
    public class TravelAgency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<TravelAgencyOffer> TravelAgencyOffers { get; set; }
    }
}
