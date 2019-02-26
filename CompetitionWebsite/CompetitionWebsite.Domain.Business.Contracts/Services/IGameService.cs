using CompetitionWebsite.Domain.Models.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Business.Contracts.Services
{
    public interface IGameService
    {

        List<Game> GetAllGames();
        Game GetGameById(int id);
        int SaveGame(Game game);
        int DeleteGame(Game game);

    }
}
