using Proiect_ASP.Models;
using Proiect_ASP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proiect_ASP.Repositories;
using Proiect_ASP.Models.DTOs;

namespace Proiect_ASP.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context) { }

        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdWithRoles(int id)
        {
            return await _context.Users
                .Include(u => u.UserRoles)
                    .ThenInclude(ur => ur.Role)
                .FirstOrDefaultAsync(u => u.Id.Equals(id));
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }

        public async void UpdateUser(int id, UserDTO dto)
        {
            User oldUser = await _context.Users.FirstOrDefaultAsync(u => u.Id.Equals(id));

            if (oldUser != null)
            {
                oldUser.FirstName = dto.FirstName;
                oldUser.LastName = dto.LastName;
                oldUser.Email = dto.Email;
                oldUser.PhoneNumber = dto.PhoneNumber;

                Update(oldUser);
                await _context.SaveChangesAsync();
            }
        }
    }
}
