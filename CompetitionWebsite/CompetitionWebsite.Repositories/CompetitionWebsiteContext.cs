using CompetitionWebsite.Domain.Models.Games;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CompetitionWebsite.Repositories
{
    public class CompetitionWebsiteContext : DbContext
    {

        //public virtual DbSet<ParticipantEvent> ParticipantEvent { get; set; }
        //public virtual DbSet<Event> Events { get; set; }
        //public virtual DbSet<Location> Locations { get; set; }

        public CompetitionWebsiteContext()
            : base(@"Data Source=(LocalDb)\SoftwareDevelopment;Initial Catalog=CompetitionWebsite;User Id=DevUser;Password=root;MultipleActiveResultSets=true;Connect Timeout=60;")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().ToTable("Game", "Admin");
            //modelBuilder.Entity<Theme>().ToTable("Themes", "Admin");
            //modelBuilder.Entity<Domain.Models.News.News>().ToTable("News", "TalentShow");
            //modelBuilder.Entity<Event>().ToTable("Events", "TalentShow");
            //modelBuilder.Entity<Participant>().ToTable("Participants", "TalentShow");

            //modelBuilder.Entity<Participant>()
            //    .HasMany<Event>(e => e.ParticipatedEvents)
            //    .WithMany(p => p.Participants)
            //        .Map(ep => {
            //            ep.MapLeftKey("FK_ParticipantEvent_Participantt");
            //            ep.MapRightKey("FK_ParticipantEvent_Even");
            //            ep.ToTable("ParticipantEvent", "TalentShow");
            //        });

        }

    }
}
