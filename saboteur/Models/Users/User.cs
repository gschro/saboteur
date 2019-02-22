using Microsoft.AspNetCore.Identity;
using saboteur.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models
{
    public class User : IdentityUser
    {
        [MaxLength(20)]
        public string First { get; set; }
        [MaxLength(20)]
        public string Last { get; set; }
        [MaxLength(40)]
        public string Timezone { get; set; }
        public int Age { get; set; }
        [MaxLength(60)]
        public string Occupation { get; set; }
        public DateTime LastLogin { get; set; }
        public int LoginCount { get; set; }
        public string SubscriptionId { get; set; }
        public string BillingId { get; set; }

        //public List<WorkTemplateUser> WorkTemplateUsers { get; set; }
        //public List<WorkUser> WorkUsers { get; set; }
        [NotMapped]
        public string FullName { get { return $"{First} {Last}"; } }
        public List<UserQuiz> UserQuizzes { get; set; }
    }
}
