using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class Host
    {
        [Key]
        public int HostId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public List<Season> Seasons { get; set; }
    }
}
