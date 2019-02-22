using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using saboteur.Interfaces;
using saboteur.ViewModels.Episode;

namespace saboteur.Controllers
{
    public class EpisodeController : Controller
    {
        private readonly IGameDataService _gameData;

        public EpisodeController(IGameDataService gameData)
        {
            _gameData = gameData;
        }

        [Route("Episode/Watch/{country}/{countrySeasonNum}/{episodeNum}")]
        public IActionResult Watch(string country, int countrySeasonNum, int episodeNum, bool preQuiz = true)
        {
            var vm = new WatchEpisodeViewModel();
            var season = _gameData.GetSeasonByCountryNum(country, countrySeasonNum);
            vm.Episode = _gameData.GetEpisodeBySeason(season.SeasonId, episodeNum);
            vm.PreQuiz = preQuiz;
            return View(vm);
        }

    }
}