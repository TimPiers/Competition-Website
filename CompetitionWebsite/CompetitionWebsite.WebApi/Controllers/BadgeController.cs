using CompetitionWebsite.Domain.Business.Contracts.Services;
using CompetitionWebsite.Domain.Business.Players;
using CompetitionWebsite.Domain.Models.Players;
using CompetitionWebsite.Repositories.Players;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace CompetitionWebsite.WebApi.Controllers
{
    public class BadgeController : ApiController
    {
        private IBadgeService _service;

        public BadgeController()
        {
            _service = new BadgeService(new BadgeRepository());
        }

        /// <summary>
        /// Get all badges.
        /// </summary>
        [Route("badges/all")]
        [HttpGet]
        public List<Badge> GetAllBadges()
        {
            try
            {
                return _service.GetAllBadges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Get badge by id.
        /// </summary>
        [Route("badges/get/{id}")]
        [HttpGet]
        public Badge GetBadgeById(int id)
        {
            try
            {
                return _service.GetBadgeById(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Save a badge
        /// </summary>
        [Route("badges/save")]
        [HttpPost]
        public int SaveBadge(Badge badge)
        {
            try
            {
                return _service.SaveBadge(badge);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// delete a badge
        /// </summary>
        [Route("badges/delete")]
        [HttpPost]
        public int DeleteBadge(Badge badge)
        {
            try
            {
                return _service.DeleteBadge(badge);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
