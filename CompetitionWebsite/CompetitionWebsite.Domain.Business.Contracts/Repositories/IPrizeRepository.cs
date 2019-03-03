using CompetitionWebsite.Domain.Models.Competitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Business.Contracts.Repositories
{
    public interface IPrizeRepository
    {

        int SavePrize(Prize prize);

    }
}
