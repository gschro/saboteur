using saboteur.Models.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Users
{
    public class UserQuizAnswer
    {
        public Guid UserQuizAnswerId { get; set; }
        public string UserQuizId { get; set; }
        public Guid QuizQuestionId { get; set; }
        public Guid QuizQuestionChoiceId { get; set; }
        public bool QuizAnswerCorrect { get; set; }
        public int TotalSeconds { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public UserQuiz UserQuiz { get; set; }
        public QuizQuestion QuizQuestion { get; set; }
        public QuizQuestionChoice QuizQuestionChoice { get; set; }
    }
}
