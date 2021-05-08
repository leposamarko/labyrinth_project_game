// <copyright file="StorageRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.Repository
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;
    using Haunted.GameModel;
    using Newtonsoft.Json;

    /// <summary>
    /// Storage Repository.
    /// </summary>
    public class StorageRepository : IStorageRepository // get files, get scores/time, load game, new time, save game
    {
        private XDocument times;
        private List<string> games;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageRepository"/> class.
        /// </summary>
        public StorageRepository()
        {
            if (this.times == null)
            {
            }
            else
            {
                this.times = XDocument.Load("times.xml");
            }

            this.games = this.GetFiles();
        }

        /// <summary>
        /// To get the files froma json.
        /// </summary>
        /// <returns>A list.</returns>
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

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public HauntedModel LoadGame(string name)
        {
            HauntedModel model;
            using (StreamReader sw = new StreamReader(name + ".json"))
            {
                string json = sw.ReadToEnd();
                model = JsonConvert.DeserializeObject<HauntedModel>(json);
            }
            return model;
        }

        /// <inheritdoc/>
        public void NewTime(string name, TimeSpan time)
        {
            if (this.times == null)
            {
                this.times = new XDocument();
                this.times.Add(new XElement("times"));
                XElement newTime = new XElement("onestime", new XElement("name", name), new XElement("time", time));
                this.times.Element("times").Add(newTime);
                this.times.Save("times.xml");
            }
            else
            {
                XElement newTime = new XElement("onestime", new XElement("name", name), new XElement("time", time));
                this.times.Element("times").Add(newTime);
                this.times.Save("times.xml");
            }
        }

        /// <inheritdoc/>
        public void SaveGame(string name, IGameModel model)
        {
            var fileName = name + ".json";
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, model);
            }

            if (!this.games.Contains(name))
            {
                this.games.Add(name);
            }
        }
    }
}
