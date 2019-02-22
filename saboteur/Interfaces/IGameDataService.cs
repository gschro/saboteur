using saboteur.Models.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Interfaces
{
    public interface IGameDataService
    {
        IEnumerable<Episode> GetEpisodes(int seasonId);
        Episode GetEpisodeBySeason(int seasonId, int episodeNum);
        Season GetSeasonByCountryNum(string country, int countrySeasonNum);
        IEnumerable<Season> GetSeasons();
        Quiz GetQuiz(string country, int countrySeasonNum, int episodeNum);
    }
}
