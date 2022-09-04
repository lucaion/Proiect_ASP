using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect_ASP.Models.DTOs;
using Proiect_ASP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelAgencyController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;

        public TravelAgencyController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetTravelAgencyByUserId(int id)
        {
            var travelAgency = await _repository.TravelAgency.GetByUserId(id);

            return Ok(travelAgency);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateTravelAgency([FromBody] TravelAgencyDTO dto)
        {
            _repository.TravelAgency.CreateTravelAgency(dto);

            await _repository.SaveAsync();

            return Ok(dto);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateTravelAgency(int id, [FromBody] TravelAgencyDTO dto)
        {
            _repository.TravelAgency.UpdateTravelAgency(id, dto);

            await _repository.SaveAsync();

            return Ok(dto);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteTravelAgency(int id)
        {
            _repository.TravelAgency.DeleteTravelAgency(id);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}
