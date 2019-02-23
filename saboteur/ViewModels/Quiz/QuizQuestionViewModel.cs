using saboteur.Models.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.ViewModels.Quiz
{
    public class QuizQuestionViewModel
    {
        public saboteur.Models.Game.QuizQuestion QuizQuestion { get; set; }
        public saboteur.Models.Game.Season Season { get; set; }
    }
}
