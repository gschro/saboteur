using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Game
{
    public class QuizQuestionChoice
    {
        [Key]
        public int QuizQuestionChoiceId { get; set; }
        public int QuizQuestionId { get; set; }
        [MaxLength(200)]
        public string Choice { get; set; }
        public bool Correct { get; set; }

        public QuizQuestion QuizQuestion { get; set; }
    }
}
