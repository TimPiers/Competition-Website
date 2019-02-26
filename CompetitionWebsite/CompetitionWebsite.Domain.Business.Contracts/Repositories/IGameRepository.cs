using CompetitionWebsite.Domain.Models.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Business.Contracts.Repositories
{
    public interface IGameRepository
    {

        List<Game> GetAllGames();
        Game GetGameById(int id);
        int SaveGame(Game game);
        int DeleteGame(Game game);

    }
}
