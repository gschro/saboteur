using saboteur.Models.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models
{
    public class Mission
    {
        [Key]
        public int MissionId { get; set; }
        public int EpisodeId { get; set; }
        [MaxLength(60)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public int PossibleEarnings { get; set; }
        public int AmountWon { get; set; }
        public int LocationId { get; set; }
        [MaxLength(200)]
        public string MissionPublicUrl { get; set; }
        
        public Episode Episode { get; set; }
        public Location Location { get; set; }
        public List<MissionPlayer> MissionPlayers { get; set; }
        public List<Reference> References { get; set; }
    }
}
