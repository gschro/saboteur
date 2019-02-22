using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class EpisodePlayer
    {
        public int EpisodeId { get; set; }
        public int PlayerId { get; set; }
        int PlayerStatusId { get; set; }
        int BribeAmount { get; set; }

        public Episode Episode { get; set; }
        public Player Player { get; set; }
        public PlayerStatus PlayerStatus { get; set; }
    }
}
