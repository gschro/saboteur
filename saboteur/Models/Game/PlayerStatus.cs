using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class PlayerStatus
    {
        [Key]
        public int PlayerStatusId { get; set; }
        [Required]
        [MaxLength(20)]
        public string status { get; set; }
    }
}
