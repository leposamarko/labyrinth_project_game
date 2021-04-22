using Haunted.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Haunted.Repository
{
    public interface IStorageRepository //save game, load game, new time/score, get scores to load the leaderboard
    {
        void SaveGame(string name, IGameModel model);
        HauntedModel LoadGame(string name);
        void NewTime(string name, TimeSpan time);
        List<TimeToXML> GetTime();
    }
}
