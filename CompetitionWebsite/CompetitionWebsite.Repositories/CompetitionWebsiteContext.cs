using CompetitionWebsite.Domain.Models.Games;
using CompetitionWebsite.Domain.Models.Players;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CompetitionWebsite.Repositories
{
    public class CompetitionWebsiteContext : DbContext
    {

        public CompetitionWebsiteContext()
            : base(@"Data Source=(LocalDb)\SoftwareDevelopment;Initial Catalog=CompetitionWebsite;User Id=DevUser;Password=root;MultipleActiveResultSets=true;Connect Timeout=60;")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().ToTable("Game", "Admin");
            modelBuilder.Entity<Badge>().ToTable("Badge", "Admin");


        }

    }
}
