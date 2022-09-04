using Proiect_ASP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_ASP.Repositories
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        ISessionTokenRepository SessionToken { get; }
        IOwnerRepository Owner { get; }
        ITravelAgencyRepository TravelAgency{ get; }
        IOfferRepository Offer{ get; }

        Task SaveAsync();
    }
}
