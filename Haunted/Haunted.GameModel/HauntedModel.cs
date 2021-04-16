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

        }
        public static int NumGhost { get { return numGhost; } }

        public int LivesCount { get => this.lifeCount; set => this.lifeCount = value; }

        public Time myTime { get; set; }

        int IGameModel.numGhost { get { return 5; } }

        int IGameModel.numKey { get { return 4; } }

        public List<Ghost> Ghosts { get; set; }
        public List<Key> Keys { get; set; }
        public Point[] Background { get; set; }
    }
}
