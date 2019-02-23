using Microsoft.EntityFrameworkCore;
using saboteur.Data;
using saboteur.Interfaces;
using saboteur.Models;
using saboteur.Models;
using saboteur.Models.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Services
{
    public class GameDataService : IGameDataService
    {
        private readonly ApplicationDbContext _db;

        public GameDataService(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Episode> GetEpisodes(int seasonId)
        {
            return _db.Episodes.Include(n=>n.Quiz).Where(n => n.SeasonId == seasonId);
        }

        public Episode GetEpisodeBySeason(int seasonId, int episodeNum)
        {
            return _db.Episodes.First(n => n.SeasonId == seasonId && n.EpisodeNum == episodeNum);
        }

        public Season GetSeasonByCountryNum(string country, int countrySeasonNum)
        {
            return _db.Seasons.First(n => n.Country == country && n.CountrySeasonNum == countrySeasonNum);
        }

        public IEnumerable<Season> GetSeasons()
        {
            return _db.Seasons.OrderBy(n=>n.Country).ThenBy(n=>n.CountrySeasonNum);
        }

        public Quiz GetQuiz(int seasonId, int episodeNum)
        {
            var episode = GetEpisodeBySeason(seasonId, episodeNum);
            return _db.Quizzes.Include(n=>n.QuizQuestions).First(n => n.EpisodeId == episode.EpisodeId);
        }

        public QuizQuestion GetQuizQuestion(int seasonId, int episodeNum, int order)
        {
            var quizQuestion = _db.QuizQuestions
                            .Include(n => n.Quiz)
                            .Include(n => n.Episode)
                            .First(n => n.Episode.SeasonId == seasonId 
                                     && n.Episode.EpisodeNum == episodeNum 
                                     && n.Order == order);
            return quizQuestion;
        }
    }
}
