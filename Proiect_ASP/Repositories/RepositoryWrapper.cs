using Proiect_ASP.Models;
using Proiect_ASP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_ASP.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly AppDbContext _context;
        private IUserRepository _user;
        private ISessionTokenRepository _sessionToken;
        private IOwnerRepository _owner;
        private ITravelAgencyRepository _travelAgency;
        private IOfferRepository _offer;
        public RepositoryWrapper(AppDbContext context)
        {
            _context = context;
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null) _user = new UserRepository(_context);
                return _user;
            }
        }

        public ISessionTokenRepository SessionToken
        {
            get
            {
                if (_sessionToken == null) _sessionToken = new SessionTokenRepository(_context);
                return _sessionToken;
            }
        }

        public IOwnerRepository Owner
        {
            get
            {
                if (_owner == null) _owner = new OwnerRepository(_context);
                return _owner;
            }
        }

        public ITravelAgencyRepository TravelAgency
        {
            get
            {
                if (_travelAgency == null) _travelAgency = new TravelAgencyRepository(_context);
                return _travelAgency;
            }
        }

        public IOfferRepository Offer
        {
            get
            {
                if (_offer == null) _offer = new OfferRepository(_context);
                return _offer;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
