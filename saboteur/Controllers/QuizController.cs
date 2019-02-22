using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using saboteur.Interfaces;
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
            var vm = new QuizPageViewModel();
            vm.Quiz = _gameData.GetQuiz(country, countrySeasonNum, episodeNum);

            return View(vm);
        }
    }
}