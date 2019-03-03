using CompetitionWebsite.Domain.Business.Contracts.Repositories;
using CompetitionWebsite.Domain.Models.Games;
using CompetitionWebsite.Domain.Models.Players;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CompetitionWebsite.Repositories.Players
{
    public class BadgeRepository : BaseRepository<Badge>, IBadgeRepository
    {
        public int DeleteBadge(Badge badge)
        {
            try
            {
                using (var context = CreateContext())
                {
                    context.Set<Badge>().Attach(badge);
                    context.Entry(badge).State = EntityState.Deleted;
                    context.SaveChanges();
                    return 1;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Badge> GetAllBadges()
        {
            try
            {
                using (var context = CreateContext())
                {
                    return context.Set<Badge>()
                        .AsNoTracking()
                        .ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Badge GetBadgeById(int id)
        {
            try
            {
                using (var context = CreateContext())
                {
                    return context.Set<Badge>()
                        .AsNoTracking()
                        .Where(x => x.Id == id)
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int SaveBadge(Badge badge)
        {
            try
            {
                if(badge.Id > 0)
                {
                    using (var context = CreateContext())
                    {
                        context.Set<Badge>().Attach(badge);
                        context.Entry(badge).State = System.Data.Entity.EntityState.Modified;
                        return context.SaveChanges();
                    }
                }
                else
                {
                    using (var context = CreateContext())
                    {
                        context.Set<Badge>().Add(badge);
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
