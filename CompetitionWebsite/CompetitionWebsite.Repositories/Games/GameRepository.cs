using CompetitionWebsite.Domain.Business.Contracts.Repositories;
using CompetitionWebsite.Domain.Models.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitionWebsite.Repositories.Games
{
    public class GameRepository : BaseRepository<Game>, IGameRepository
    {
        public int DeleteGame(Game game)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetAllGames()
        {
            using (var context = CreateContext())
            {
                return context.Set<Game>()
                    .AsNoTracking()
                    .ToList();
            }
        }

        public Game GetGameById(int id)
        {
            using (var context = CreateContext()) {
                return context.Set<Game>()
                    .AsNoTracking()
                    .Where(x => x.Id == id)
                    .FirstOrDefault();
            }
        }

        public int SaveGame(Game game)
        {
            // Update
            if(game.Id > 0)
            {
                try
                {
                    using (var context = CreateContext())
                    {
                        context.Set<Game>().Attach(game);
                        context.Entry(game).State = System.Data.Entity.EntityState.Modified;
                        return context.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else // New
            {
                try
                {
                    using (var context = CreateContext())
                    {
                        context.Set<Game>().Add(game);
                        return context.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
