using Proiect_ASP.Models.DTOs;
using Proiect_ASP.Models.Entities;
using Proiect_ASP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_ASP.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByEmail(string email);
        Task<User> GetByIdWithRoles(int id);
        void UpdateUser(int id, UserDTO dto);
    }
}
