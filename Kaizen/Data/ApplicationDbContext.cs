using Kaizen.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaizen.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tea> Teas { get; set; }

        public DbSet<Season> Seasons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            //base.OnModelCreating(modelbuilder);
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<Season>().HasData(
               new Season { SeasonId = 1, farmerName = "Jhon", farmerEmail = "jhon@gmail.com", farmerPhoneNumber = "1234567890" });
            modelbuilder.Entity<Season>().HasData(
               new Season { SeasonId = 2, farmerName = "tyreece", farmerEmail = "Tyreece@gmail.com", farmerPhoneNumber = "1234567899" });
            modelbuilder.Entity<Season>().HasData(
               new Season { SeasonId =3, farmerName = "Hella", farmerEmail = "Hella@gmail.com", farmerPhoneNumber = "1234567888" });
           // modelbuilder.Entity<Season>().HasData(
             //  new Season { SeasonId = 3, });


            modelbuilder.Entity<Tea>().HasData(
                new Tea {
                    TeaId = 0,
                    TeaName = "Sencha",
                    TeaDescription = "greenTea",
                    Price = 50.99M,
                   // Season = _seasonRepository.GetAllSeasons.ToList()[0],
                    Seasonid = 0,
                    Tea_Stock = 15
                });
            modelbuilder.Entity<Tea>().HasData(
                new Tea
                {
                    TeaId = 1,
                    TeaName = "Fukamushi Sencha",
                    TeaDescription = "greenTea",
                    Price = 55.99M,
                   // Season = _seasonRepository.GetAllSeasons.ToList()[0],
                    Seasonid = 0,
                    Tea_Stock = 10
                });
            modelbuilder.Entity<Tea>().HasData(
                new Tea
                {
                    TeaId = 2,
                    TeaName = "Gyokuro",
                    TeaDescription = "greenTea",
                    Price = 60.99M,
                   // Season = _seasonRepository.GetAllSeasons.ToList()[2],
                    Seasonid = 2,
                    Tea_Stock = 10
                });


        }
    }
}

