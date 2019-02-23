using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using saboteur.Interfaces;
using saboteur.Models.Game;
using saboteur.ViewModels.Quiz;

namespace saboteur.Controllers
{
    public class QuizController : Controller
    {
        private readonly IGameDataService _gameData;

        public QuizController(IGameDataService gameData)
        {
            _gameData = gameData;
        }

        [Route("Quiz/{country}/{countrySeasonNum}/{episodeNum}")]
        public IActionResult Quiz(string country, int countrySeasonNum, int episodeNum)
        {
            var season = _gameData.GetSeasonByCountryNum(country, countrySeasonNum);
            var vm = new QuizViewModel();
            vm.Quiz = _gameData.GetQuiz(season.SeasonId, episodeNum);
            vm.Season = season;

            return View(vm);
        }

        [Route("Quiz/Question/{country}/{countrySeasonNum}/{episodeNum}/Order")]
        public IActionResult Question(string country, int countrySeasonNum, int episodeNum, int order)
        {
            var season = _gameData.GetSeasonByCountryNum(country, countrySeasonNum);
            var quizQuestion = _gameData.GetQuizQuestion(season.SeasonId, episodeNum, order);
            var vm = new QuizQuestionViewModel();
            vm.QuizQuestion = quizQuestion;
            vm.Season = season;

            return View(vm);
        }
    }
}