using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class PlayerPenalty
    {
        public int PlayerId { get; set; }        
        public int PenaltyId { get; set; }
        
        public Player Player { get; set; }
        public Penalty Penalty { get; set; }
    }
}
