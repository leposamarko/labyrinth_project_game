using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Haunted.GameModel
{
    public class Key:Element
    {
        public Key(double x, double y)
        {
            this.area = new Rect(x, y, Config.KeySize, Config.KeySize);
        }
    }
}
