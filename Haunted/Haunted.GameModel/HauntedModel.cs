using System;
using System.Collections.Generic;
using System.Drawing;
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
    }
}
