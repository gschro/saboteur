using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        [MaxLength(40)]
        public string City { get; set; }
        [MaxLength(40)]
        public string State { get; set; }
        [MaxLength(40)]
        public string Country { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public bool PlayerLocation { get; set; }
    }
}
