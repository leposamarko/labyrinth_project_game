using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace Haunted.GameModel
{
    public class Time :Element
    {
        public Time(double x, double y)
        {
            this.area = new Rect(x, y, Config.TimeTextSize, Config.TimeTextSize);
        }
    }
}
