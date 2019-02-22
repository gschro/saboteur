using saboteur.Models.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.Users
{
    public class UserQuiz
    {
        public Guid UserQuizId { get; set; }
        public string UserId { get; set; }
        public int EpisodeId { get; set; }
        public int QuestionsCorrect { get; set; }
        public int TotalQuestions { get; set; }
        public int TotalSeconds { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public Episode Episode { get; set; }
        public User User { get; set; }
        public List<UserQuizAnswer> UserQuizAnswers { get; set; }
    }
}
