using Microsoft.EntityFrameworkCore;
using saboteur.Data;
using saboteur.Interfaces;
using saboteur.Models;
using saboteur.Models;
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

        public Season GetSeasonByCountryNum(string country, int countrySeasonNum)
        {
            return _db.Seasons.First(n => n.Country == country && n.CountrySeasonNum == countrySeasonNum);
        }

        public IEnumerable<Season> GetSeasons()
        {
            return _db.Seasons.OrderBy(n=>n.Country).ThenBy(n=>n.CountrySeasonNum);
        }

        public Episode GetEpisodeBySeason(int seasonId, int episodeNum)
        {
            return _db.Episodes.First(n => n.SeasonId == seasonId && n.EpisodeNum == episodeNum);
        }
    }
}
