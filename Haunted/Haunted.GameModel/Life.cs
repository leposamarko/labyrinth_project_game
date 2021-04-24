using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Haunted.GameModel
{
    class Life :Element
    {
        public Life(double x, double y)
        {
            this.area = new Rect(x, y, Config.HeartSize, Config.HeartSize);
        }
    }
}
