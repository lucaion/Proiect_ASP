using Proiect_ASP.Models.DTOs;
using Proiect_ASP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_ASP.Repositories
{
    public interface IOwnerRepository : IGenericRepository<Owner>
    {
        void CreateOwner(OwnerDTO ownerDTO);
        Task<List<Owner>> GetOwnerById(int id);
        void UpdateOwner(int id, OwnerDTO ownerDTO);
        void DeleteOwner(int id);
    }
}
