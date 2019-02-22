using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using saboteur.Interfaces;
using saboteur.ViewModels.Season;

namespace saboteur.Controllers
{
    public class SeasonController : Controller
    {
        private readonly IGameDataService _gameData;

        public SeasonController(IGameDataService gameData)
        {
            _gameData = gameData;
        }

        [Route("Season/{country}/{countrySeasonNum}")]
        public IActionResult Index(string country, int countrySeasonNum)
        {
            var vm = new SeasonViewModel();
            var season = _gameData.GetSeasonByCountryNum(country, countrySeasonNum);
            vm.Episodes = _gameData.GetEpisodes(season.SeasonId).ToList();
            return View(vm);
        }
    }
}