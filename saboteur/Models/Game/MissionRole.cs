using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class MissionRole
    {
        [Key]
        public int MissionRoleId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Role { get; set; }
    }
}
