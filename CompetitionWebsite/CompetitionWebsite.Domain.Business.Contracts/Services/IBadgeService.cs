using CompetitionWebsite.Domain.Models.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Business.Contracts.Services
{
    public interface IBadgeService
    {

        List<Badge> GetAllBadges();
        Badge GetBadgeById(int id);
        int SaveBadge(Badge badge);
        int DeleteBadge(Badge badge);


    }
}
