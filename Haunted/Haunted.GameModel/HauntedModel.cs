using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted.GameModel
{
    public class HauntedModel : IGameModel
    {
        public bool[,] Walls { get; set; }
        public Point Player { get; set ; }
        public Point Exit { get; set; }
        public Point Key { get; set; }
        public double GameWidth { get; set; }
        public double GameHeight { get; set; }
        public double TileSize { get; set; }


        const int numGhost = 5;
        private int lifeCount = 3;
        private int numKey = 4;

        public HauntedModel()
        {
            this.Keys = new List<Key>();      //ez a kettő a szellem és kulcs randomizer lenne, egyenlőre ezt így hagyom, passz hogy itt kell e megcsinálni vagy nem
            this.Ghosts = new List<Ghost>();
            this.myTime = new Time(Config.TimePlaceX, Config.TimePlaceY);

            this.Background = new Point[2];
            this.Background[0] = new Point(0, 0);   //ez a 3 bacgroundos még passz hogy mi, egyenlőre itt lesz max áttírjuk ha rájövünk mire jó
            this.Background[1] = new Point(Config.GameWidth - 1, 0);
        }
        public static int NumGhost { get { return numGhost; } }

        public int LivesCount { get => this.lifeCount; set => this.lifeCount = value; }

        public Time myTime { get; set; }

        int IGameModel.numGhost { get { return 4; } } //randomizerhez a számok, ugye azért 1el kevesebb meet a for ciklus 0-ról indul

        int IGameModel.numKey { get { return 3; } }

        public List<Ghost> Ghosts { get; set; }
        public List<Key> Keys { get; set; }
        public Point[] Background { get; set; }
    }
}
