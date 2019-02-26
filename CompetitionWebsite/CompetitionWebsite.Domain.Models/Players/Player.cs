using CompetitionWebsite.Domain.Models.Competitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Models.Players
{
    public class Player
    {

        public Player()
        {
            Competitions = new List<Competition>();
            Badges = new List<Badge>();
        }

        public int Id { get; set; }

        public List<Competition> Competitions;
        public List<Badge> Badges;
    }
}
