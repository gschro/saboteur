using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using saboteur.Interfaces;

namespace saboteur.Controllers
{
    public class QuizController : Controller
    {
        private readonly IGameDataService _gameData;

        public QuizController(IGameDataService gameData)
        {
            _gameData = gameData;
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}