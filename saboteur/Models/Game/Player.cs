using saboteur.Models.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        public int Age { get; set; }
        [MaxLength(40)]
        public string Occupation { get; set; }
        public int LocationId { get; set; }
        public int FinalPlayerStatusId { get; set; }
        public int PlayerStatusEpisodeId { get; set; }
        public int TotalEarnings { get; set; }
        public string PicutreUrl { get; set; }

        public Location Location { get; set; }
        public PlayerStatus PlayerStatus { get; set; }
        public Episode PlayerStatusEpisode { get; set; }
        public List<MissionPlayer> MissionPlayers { get; set; }
        public List<Reference> References { get; set; }
        public List<PlayerPenalty> PlayerPenalties { get; set; }
        public List<EpisodePlayer> EpisodePlayers { get; set; }
    }
}
