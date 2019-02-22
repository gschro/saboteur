using saboteur.Models.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class Episode
    {
        [Key]
        public int EpisodeId { get; set; }
        [Required]
        public int SeasonId { get; set; }
        [Required]
        public int EpisodeNum {get; set;}
        [Required]
        [MaxLength(60)]
        public string Title { get; set; }
        [MaxLength(2000)]
        public string Description { get; set; }
        //[MaxLength(200)]
        //public string PurchaseUrl { get; set; }
        [MaxLength(200)]
        public string FullEpisodePublicUrl { get; set; }
        [MaxLength(200)]
        public string PreQuizPublicUrl { get; set; }
        [MaxLength(200)]
        public string PostQuizPublicUrl { get; set; }
        public DateTime? AirDate { get; set; }

        public Season Season { get; set; }
        public List<Reference> References { get; set; }
        public Quiz Quiz { get; set; }
        public List<Mission> Missions { get; set; }
        public List<EpisodePlayer> EpisodePlayers { get; set; }
    }
}
