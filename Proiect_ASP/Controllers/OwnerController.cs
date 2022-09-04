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
    public class OwnerController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;

        public OwnerController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetOwnerById(int id)
        {
            var owner = await _repository.Owner.GetOwnerById(id);

            return Ok(owner);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateAddress([FromBody] OwnerDTO dto)
        {
            _repository.Owner.CreateOwner(dto);

            await _repository.SaveAsync();

            return Ok(dto);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateAddress(int id, [FromBody] OwnerDTO dto)
        {
            _repository.Owner.UpdateOwner(id, dto);

            await _repository.SaveAsync();

            return Ok(dto);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteOwner(int id)
        {
            _repository.Owner.DeleteOwner(id);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}
