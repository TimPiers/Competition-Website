using CompetitionWebsite.Domain.Models.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Business.Contracts.Repositories
{
    public interface IBadgeRepository
    {

        List<Badge> GetAllBadges();
        Badge GetBadgeById(int id);
        int SaveBadge(Badge badge);
        int DeleteBadge(Badge badge);

    }
}
