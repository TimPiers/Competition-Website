using CompetitionWebsite.Domain.Business.Contracts.Repositories;
using CompetitionWebsite.Domain.Business.Contracts.Services;
using CompetitionWebsite.Domain.Models.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Business.Players
{
    public class BadgeService : IBadgeService
    {

        IBadgeRepository _repository;

        public BadgeService(IBadgeRepository repository)
        {
            _repository = repository;
        }

        public int DeleteBadge(Badge badge)
        {
            try
            {
                return _repository.DeleteBadge(badge);
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
                return _repository.GetAllBadges();
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
                return _repository.GetBadgeById(id);
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
                return _repository.SaveBadge(badge);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
