using CompetitionWebsite.Domain.Models.Competitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Business.Contracts.Services
{
    public interface ICompetitionService
    {

        List<Competition> GetAllCompetitions();
        int SaveCompetition(Competition competition);
        int DeleteCompetition(Competition competition);

    }
}
