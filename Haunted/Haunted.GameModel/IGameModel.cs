using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted.GameModel
{
    public interface IGameModel //megj.: Az órához stopwatch-ot kell használni, melyet xy.stop() után .elapsed-el el lehet menteni egy timespanbe -> https://stackoverflow.com/questions/13690708/timer-c-sharp-use-in-game-development
    {
        public bool[,] Walls { get; set; }
        public GirlPlayer Player { get; set; }
        public Point Exit { get; set; }
        public Key Key { get; set; }
        public double GameWidth { get;  set; } // Pixel size
        public double GameHeight { get;  set; } // Pixel sizes 
        public double TileSize { get; set; }
        public int LivesCount { get; set; } //nemtom ezek kellenek max majd kiszedjük
        public int numGhost { get; }
        public int numKey { get; }
        List<Ghost> Ghosts { get; set; }
        List<Key> Keys { get; set; }
        Point[] Background { get; set; }
    }
}
 