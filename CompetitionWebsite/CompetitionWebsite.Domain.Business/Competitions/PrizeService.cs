using CompetitionWebsite.Domain.Business.Contracts.Repositories;
using CompetitionWebsite.Domain.Business.Contracts.Services;
using CompetitionWebsite.Domain.Models.Competitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Business.Competitions
{
    public class PrizeService : IPrizeService
    {

        IPrizeRepository _repository;

        public PrizeService(IPrizeRepository repository)
        {
            _repository = repository;
        }

        public int SavePrize(Prize prize)
        {
            try
            {
                return _repository.SavePrize(prize);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
