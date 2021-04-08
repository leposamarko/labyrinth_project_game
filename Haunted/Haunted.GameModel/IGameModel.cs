using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted.GameModel
{
    public interface IGameModel
    {
        public bool[,] Walls { get; set; }
        public Point Player { get; set; }
        public Point Exit { get; set; }
        public Point Key { get; set; }
        public double GameWidth { get;  set; } // Pixel size
        public double GameHeight { get;  set; } // Pixel sizes 
        public double TileSize { get; set; }
    }
}
 