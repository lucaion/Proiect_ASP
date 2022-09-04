using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proiect_ASP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_ASP.Models
{
    public class AppDbContext : IdentityDbContext<User, Role, int,
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<SessionToken> SessionTokens { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<TravelAgency> TravelAgencies { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<TravelAgencyOffer> TravelAgencyOffers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserRole>(ur =>
            {
                ur.HasKey(ur => new { ur.UserId, ur.RoleId });

                ur.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId);
                ur.HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(ur => ur.UserId);

            });

            builder.Entity<Owner>().HasOne(o => o.TravelAgency).WithOne(tr => tr.Owner);

            builder.Entity<User>().HasMany(u => u.TravelAgencies).WithOne(tr => tr.User);

            builder.Entity<TravelAgencyOffer>(tao =>
            {
                tao.HasKey(tao => new { tao.TravelAgencyId, tao.OfferId });

                tao.HasOne(tao => tao.Offer).WithMany(o => o.TravelAgencyOffers).HasForeignKey(tao => tao.OfferId);
                tao.HasOne(tao => tao.TravelAgency).WithMany(tr => tr.TravelAgencyOffers).HasForeignKey(tao => tao.TravelAgencyId);
            });
        }
    }
}
