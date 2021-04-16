using Haunted.GameModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Haunted.Repository
{
    class StorageRepository : IStorageRepository //get files, get scores/time, load game, new time, save game
    {
        private XDocument times;
        private List<string> games;

        public StorageRepository()
        {
            this.times = XDocument.Load("times.xml");
            this.games = this.GetFiles();
        }
        public List<string> GetFiles()
        {
            var files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.json").ToList();
            List<string> names = new List<string>();
            foreach (var item in files)
            {
                var name = Path.GetFileNameWithoutExtension(item);
                names.Add(name);
            }

            return names;
        }

        public List<TimeToXML> GetTime()
        {
            List<TimeToXML> time = new List<TimeToXML>();
            foreach (XElement item in this.times.Root.Descendants("onestime"))
            {
                time.Add(new TimeToXML(item.Element("name").Value, TimeSpan.Parse(item.Element("time").Value)));
            }
            List<TimeToXML> inOrder = time.OrderByDescending(x => x.Time).ToList();
            return inOrder;
        }

        public HauntedModel LoadGame(string name)
        {
            throw new NotImplementedException();
        }

        public void NewTime(string name, TimeSpan time)
        {
            throw new NotImplementedException();
        }

        public void SaveGame(string name, IGameModel model)
        {
            throw new NotImplementedException();
        }
    }
}
