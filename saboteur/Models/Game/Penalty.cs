using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class Penalty
    {
        [Key]
        public int PenaltyId { get; set; }
        [Required]
        public int Amount { get; set; }
        public int MissionId { get; set; }
        public int EpisodeId { get; set; }

        public Mission Mission { get; set; }
        public Episode Episode { get; set; }
        public List<PlayerPenalty> PlayerPenalties { get; set; }
    }
}
