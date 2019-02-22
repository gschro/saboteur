using saboteur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Interfaces
{
    public interface IGameDataService
    {
        IEnumerable<Episode> GetEpisodes(int seasonId);
        Season GetSeasonByCountryNum(string country, int countrySeasonNum);
        IEnumerable<Season> GetSeasons();
        Episode GetEpisodeBySeason(int seasonId, int episodeNum);
    }
}
