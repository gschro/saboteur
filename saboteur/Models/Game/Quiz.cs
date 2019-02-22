using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class Quiz
    {
        [Key]
        public int QuizId { get; set; }
        [Required]
        [MaxLength(60)]
        public string Title { get; set; }
        public int? EpisodeId { get; set; }

        public List<QuizQuestion> QuizQuestions { get; set; }
        public Episode Episode { get; set; }
    }
}
