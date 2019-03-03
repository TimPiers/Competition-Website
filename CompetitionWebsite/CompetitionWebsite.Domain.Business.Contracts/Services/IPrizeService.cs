using CompetitionWebsite.Domain.Models.Competitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Business.Contracts.Services
{
    public interface IPrizeService
    {

        int SavePrize(Prize prize);

    }
}
