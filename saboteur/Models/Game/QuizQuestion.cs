using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class QuizQuestion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid QuizQuestionId { get; set; }
        public int EpisodeId { get; set; }
        public int Order { get; set; }
        [MaxLength(200)]
        public string Question { get; set; }

        public List<QuizQuestionChoice> QuizQuestionChoices { get; set; }
        public Episode Episode { get; set; }
    }
}
