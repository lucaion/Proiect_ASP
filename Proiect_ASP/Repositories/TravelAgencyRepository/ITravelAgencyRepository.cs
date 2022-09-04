﻿using Proiect_ASP.Models.DTOs;
using Proiect_ASP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_ASP.Repositories
{
    public interface ITravelAgencyRepository : IGenericRepository<TravelAgency>
    {
        void CreateTravelAgency(TravelAgencyDTO dto);
        Task<List<TravelAgency>> GetByUserId(int id);
        void UpdateTravelAgency(int id, TravelAgencyDTO dto);
        void DeleteTravelAgency(int id);
    }
}
