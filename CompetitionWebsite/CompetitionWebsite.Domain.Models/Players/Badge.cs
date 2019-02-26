using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Models.Players
{
    public class Badge
    {

        public Badge()
        {
            Players = new List<Player>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string IconPath { get; set; }

        public List<Player> Players { get; set; }
    }
}
