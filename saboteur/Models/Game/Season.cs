using saboteur.Models.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class Season
    {
        [Key]
        public int SeasonId { get; set; }
        [MaxLength(60)]
        public string Title { get; set; }
        public int HostId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [MaxLength(20)]
        public string Station { get; set; }
        [MaxLength(20)]
        public string Country { get; set; }
        public int CountrySeasonNum { get; set; }
        public int MaxPot { get; set; }
        public int EarnedPot { get; set; }
        [MaxLength(200)]
        public string PublicUrl { get; set; }
        [MaxLength(200)]
        public string PurchaseUrl { get; set; }

        public List<Reference> References { get; set; }
        public Host Host { get; set; }
    }
}
