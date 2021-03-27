using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted.GameLogic
{
    interface IGameLogic
    {
        public bool move(int dx, int dy);
        public void initmodel(string fname);
        public Point GetTilePos(Point mousePos);
    }
}
