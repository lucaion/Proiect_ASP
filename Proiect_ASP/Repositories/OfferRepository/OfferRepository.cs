using Microsoft.EntityFrameworkCore;
using Proiect_ASP.Models;
using Proiect_ASP.Models.DTOs;
using Proiect_ASP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_ASP.Repositories
{
    public class OfferRepository : GenericRepository<Offer>, IOfferRepository
    {
        public OfferRepository(AppDbContext context) : base(context) { }

        public void CreateOffer(OfferDTO dto)
        {
            Offer newOffer = new Offer();

            newOffer.Location = dto.Location;
            newOffer.Price = dto.Price;

            Create(newOffer);
        }

        public async Task<List<Offer>> GetOfferById(int id)
        {
            return await _context.Offers.Where(of => of.Id.Equals(id)).ToListAsync();
        }

        public void UpdateOffer(int id, OfferDTO dto)
        {
            Offer newOffer = new Offer();

            newOffer.Id = id;
            newOffer.Location = dto.Location;
            newOffer.Price = dto.Price;

            Update(newOffer);
        }

        public async void DeleteOffer(int id)
        {
            Offer offer = new Offer();
            offer = await GetByIdAsync(id);

            Delete(offer);
        }
    }
}
