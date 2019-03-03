using CompetitionWebsite.Domain.Business.Contracts.Services;
using CompetitionWebsite.Domain.Business.Games;
using CompetitionWebsite.Domain.Models.Games;
using CompetitionWebsite.Repositories.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CompetitionWebsite.WebApi.Controllers
{
    public class GameController : ApiController
    {
        private IGameService _service;

        public GameController()
        {
            _service = new GameService(new GameRepository());
        }

        /// <summary>
        /// Get all games.
        /// </summary>
        [Route("games/all")]
        [HttpGet]
        public List<Game> GetAllGames()
        {
            try
            {
                return _service.GetAllGames();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Get game by id.
        /// </summary>
        [Route("games/get/{id}")]
        [HttpGet]
        public Game GetGameById(int id)
        {
            try
            {
                return _service.GetGameById(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Save a game
        /// </summary>
        [Route("games/save")]
        [HttpPost]
        public int SaveGame(Game game)
        {
            try
            {
                return _service.SaveGame(game);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// delete a game
        /// </summary>
        [Route("games/delete")]
        [HttpPost]
        public int DeleteGame(Game game)
        {
            try
            {
                return _service.DeleteGame(game);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }
    }
}
