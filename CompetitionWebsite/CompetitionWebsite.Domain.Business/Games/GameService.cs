using CompetitionWebsite.Domain.Business.Contracts.Repositories;
using CompetitionWebsite.Domain.Business.Contracts.Services;
using CompetitionWebsite.Domain.Models.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Business.Games
{
    public class GameService : IGameService
    {

        IGameRepository _repository;

        public GameService(IGameRepository repository)
        {
            _repository = repository;
        }

        public int DeleteGame(Game game)
        {
            return _repository.DeleteGame(game);
        }

        public List<Game> GetAllGames()
        {
            return _repository.GetAllGames();
        }

        public Game GetGameById(int id)
        {
            return _repository.GetGameById(id);
        }

        public int SaveGame(Game game)
        {
            return _repository.SaveGame(game);
        }
    }
}
