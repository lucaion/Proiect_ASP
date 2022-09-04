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
    public class OwnerRepository : GenericRepository<Owner>, IOwnerRepository
    {
        public OwnerRepository(AppDbContext context) : base(context) { }

        public async void CreateOwner(OwnerDTO ownerDTO)
        {
            Owner newOwner = new Owner();

            newOwner.FirstName = ownerDTO.FirstName;
            newOwner.LastName = ownerDTO.LastName;
            newOwner.Age = ownerDTO.Age;

            Create(newOwner);
        }

        public async Task<List<Owner>> GetOwnerById(int id)
        {
            return await _context.Owners.Where(o => o.Id.Equals(id)).ToListAsync();
        }

        public async void UpdateOwner(int id, OwnerDTO ownerDTO)
        {
            Owner newOwner = new Owner();

            newOwner.Id = id;
            newOwner.FirstName = ownerDTO.FirstName;
            newOwner.LastName = ownerDTO.LastName;
            newOwner.Age = ownerDTO.Age;

            Update(newOwner);
        }

        public async void DeleteOwner(int id)
        {
            Owner owner = new Owner();
            owner = await GetByIdAsync(id);

            Delete(owner);
        }
    }
}
