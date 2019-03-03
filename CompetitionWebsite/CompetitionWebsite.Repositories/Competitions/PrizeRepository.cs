using CompetitionWebsite.Domain.Business.Contracts.Repositories;
using CompetitionWebsite.Domain.Models.Competitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Repositories.Competitions
{
    public class PrizeRepository : BaseRepository<Prize>, IPrizeRepository
    {
        public int SavePrize(Prize prize)
        {
            try
            {
                if (prize.Id > 0)
                {
                    using (var context = CreateContext())
                    {
                        context.Set<Prize>().Attach(prize);
                        context.Entry(prize).State = System.Data.Entity.EntityState.Modified;
                        return context.SaveChanges();
                    }
                }
                else
                {
                    using (var context = CreateContext())
                    {
                        context.Set<Prize>().Add(prize);
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
