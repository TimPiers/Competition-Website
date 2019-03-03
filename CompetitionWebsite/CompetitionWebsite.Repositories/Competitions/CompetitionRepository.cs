using CompetitionWebsite.Domain.Business.Contracts.Repositories;
using CompetitionWebsite.Domain.Models.Competitions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CompetitionWebsite.Repositories.Competitions
{
    public class CompetitionRepository : BaseRepository<Competition>, ICompetitionRepository
    {
        public int DeleteCompetition(Competition competition)
        {
            try
            {
                using (var context = CreateContext())
                {
                    context.Set<Competition>().Attach(competition);
                    context.Entry(competition).State = EntityState.Deleted;
                    return context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Competition> GetAllCompetitions()
        {
            try
            {
                using (var context = CreateContext())
                {
                    return context.Set<Competition>()
                        .AsNoTracking()
                        .Include(game => game.Game)
                        .Include(prize => prize.Prize)
                        .Include(prizeBadge => prizeBadge.Prize.Badge)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int SaveCompetition(Competition competition)
        {
            try
            {
                if (competition.Id > 0)
                {
                    using (var context = CreateContext())
                    {
                        context.Set<Competition>().Attach(competition);
                        context.Entry(competition).State = EntityState.Modified;
                        return context.SaveChanges();
                    }
                }
                else
                {
                    using (var context = CreateContext())
                    {
                        context.Set<Competition>().Add(competition);
                        return context.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
