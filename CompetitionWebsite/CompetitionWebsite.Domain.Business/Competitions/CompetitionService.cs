using CompetitionWebsite.Domain.Business.Contracts.Repositories;
using CompetitionWebsite.Domain.Business.Contracts.Services;
using CompetitionWebsite.Domain.Models.Competitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Business.Competitions
{
    public class CompetitionService : ICompetitionService
    {

        ICompetitionRepository _repository;

        public CompetitionService(ICompetitionRepository repository)
        {
            _repository = repository;
        }

        public int DeleteCompetition(Competition competition)
        {
            try
            {
                return _repository.DeleteCompetition(competition);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Competition> GetAllCompetitions()
        {
            try
            {
                return _repository.GetAllCompetitions();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int SaveCompetition(Competition competition)
        {
            try
            {
                return _repository.SaveCompetition(competition);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
