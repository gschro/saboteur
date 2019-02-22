using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class MissionSort
    {
        [Key]
        public int MissionSortId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Sort { get; set; }
    }
}
