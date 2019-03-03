using CompetitionWebsite.Domain.Models.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Models.Competitions
{
    public class Prize
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Badge Badge { get; set; }
        public int BadgeId { get; set; }
    }
}
