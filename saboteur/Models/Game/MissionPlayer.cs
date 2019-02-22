using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class MissionPlayer
    {
        public int MissionId { get; set; }
        public int PlayerId { get; set; }
        public int MissionSortId { get; set; }
        public int MissionRoleId { get; set; }

        public Mission Mission { get; set; }
        public Player Player { get; set; }
        public MissionSort MissionSort { get; set; }
        public MissionRole MissionRole { get; set; }
    }
}
