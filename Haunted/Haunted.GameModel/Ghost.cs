using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Haunted.GameModel
{
    public class Ghost : Element
    {
        public Ghost(int x, int y)
        {
            this.area = new Rect(x,y,Config.GhostWidth, Config.GhostHeight)
        }
    }
}
