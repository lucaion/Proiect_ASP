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
    public class OfferController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;

        public OfferController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetOfferById(int id)
        {
            var offer = await _repository.Offer.GetOfferById(id);

            return Ok(offer);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateOffer([FromBody] OfferDTO dto)
        {
            _repository.Offer.CreateOffer(dto);

            await _repository.SaveAsync();

            return Ok(dto);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateOffer(int id, [FromBody] OfferDTO dto)
        {
            _repository.Offer.UpdateOffer(id, dto);

            await _repository.SaveAsync();

            return Ok(dto);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteOffer(int id)
        {
            _repository.Offer.DeleteOffer(id);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}
