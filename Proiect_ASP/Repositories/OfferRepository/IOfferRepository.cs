using Proiect_ASP.Models.DTOs;
using Proiect_ASP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_ASP.Repositories
{
    public interface IOfferRepository : IGenericRepository<Offer>
    {
        void CreateOffer(OfferDTO dto);
        Task<List<Offer>> GetOfferById(int id);
        void UpdateOffer(int id, OfferDTO dto);
        void DeleteOffer(int id);
    }
}
