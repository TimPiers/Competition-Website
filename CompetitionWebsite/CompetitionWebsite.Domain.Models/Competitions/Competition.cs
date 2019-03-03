using CompetitionWebsite.Domain.Models.Enums;
using CompetitionWebsite.Domain.Models.Games;
using CompetitionWebsite.Domain.Models.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Models.Competitions
{
    public class Competition
    {

        public Competition()
        {
            Players = new List<Player>();
            Winners = new List<Player>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public CompetitionStatus Status { get; set; }

        public Game Game { get; set; }
        public int GameId { get; set; }

        public Prize Prize { get; set; }
        public int PrizeId { get; set; }

                public List<Player> Players;
        public List<Player> Winners;
    }
}
