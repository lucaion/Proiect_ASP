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
    public class TravelAgencyRepository : GenericRepository<TravelAgency>, ITravelAgencyRepository
    {
        public TravelAgencyRepository(AppDbContext context) : base(context) { }

        public async void CreateTravelAgency(TravelAgencyDTO dto)
        {
            TravelAgency newTravelAgency = new TravelAgency();

            newTravelAgency.Name = dto.Name;
            newTravelAgency.OwnerId = dto.OwnerId;
            newTravelAgency.UserId = dto.UserId;

            Create(newTravelAgency);
        }

        public async Task<List<TravelAgency>> GetByUserId(int id)
        {
            return await _context.TravelAgencies.Where(tr => tr.UserId.Equals(id)).ToListAsync();
        }

        public async void UpdateTravelAgency(int id, TravelAgencyDTO dto)
        {
            TravelAgency newTravelAgency = new TravelAgency();

            newTravelAgency.Id = id;
            newTravelAgency.Name = dto.Name;
            newTravelAgency.OwnerId = dto.OwnerId;
            newTravelAgency.UserId = dto.UserId;

            Update(newTravelAgency);
        }

        public async void DeleteTravelAgency(int id)
        {
            TravelAgency travelAgency = new TravelAgency();
            travelAgency = await GetByIdAsync(id);

            Delete(travelAgency);
        }
    }
}
