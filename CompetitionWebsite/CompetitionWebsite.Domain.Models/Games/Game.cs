using CompetitionWebsite.Domain.Models.Competitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionWebsite.Domain.Models.Games
{
    public class Game
    {

        public Game()
        {
            Competitions = new List<Competition>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseYear { get; set; }

        public List<Competition> Competitions;
    }
}
