using System;
using System.Collections.Generic;
using CompetitionWebsite.Domain.Business.Contracts.Repositories;
using CompetitionWebsite.Domain.Business.Contracts.Services;
using CompetitionWebsite.Domain.Business.Games;
using CompetitionWebsite.Domain.Models.Games;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace CompetitionWebsite.UnitTests
{
    [TestClass]
    public class GameTest
    {

        IGameService _service;
        IGameRepository _repository;

        public GameTest()
        {
            _repository = Substitute.For<IGameRepository>();
            _service = new GameService(_repository);
        }

        [TestMethod]
        public void Test_GetAllGames_Returns_ListOfGames()
        {
            List<Game> games = new List<Game>();
            _repository.GetAllGames().Returns(games);
            _service.GetAllGames().Should().NotBeNull();
        }

        [TestMethod]
        public void Test_GetGameById_Returns_Game()
        {
            Game game = new Game();
            _repository.GetGameById(1).Returns(game);
            _service.GetGameById(1).Should().Be(game);
        }

    }
}
