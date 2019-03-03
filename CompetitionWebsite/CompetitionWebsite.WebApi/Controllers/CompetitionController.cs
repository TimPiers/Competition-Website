using CompetitionWebsite.Domain.Business.Competitions;
using CompetitionWebsite.Domain.Business.Contracts.Services;
using CompetitionWebsite.Domain.Business.Players;
using CompetitionWebsite.Domain.Models.Competitions;
using CompetitionWebsite.Domain.Models.Players;
using CompetitionWebsite.Repositories.Competitions;
using CompetitionWebsite.Repositories.Players;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace CompetitionWebsite.WebApi.Controllers
{
    public class CompetitionController : ApiController
    {
        private ICompetitionService _service;

        public CompetitionController()
        {
            _service = new CompetitionService(new CompetitionRepository());
        }

        /// <summary>
        /// Get all Competitions.
        /// </summary>
        [Route("competitions/all")]
        [HttpGet]
        public List<Competition> GetAllCompetitions()
        {
            try
            {
                return _service.GetAllCompetitions();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Save a Competition
        /// </summary>
        [Route("competitions/save")]
        [HttpPost]
        public int SaveCompetition(Competition competition)
        {
            try
            {
                return _service.SaveCompetition(competition);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// delete a Competition
        /// </summary>
        [Route("competitions/delete")]
        [HttpPost]
        public int DeleteCompetition(Competition competition)
        {
            try
            {
                return _service.DeleteCompetition(competition);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
