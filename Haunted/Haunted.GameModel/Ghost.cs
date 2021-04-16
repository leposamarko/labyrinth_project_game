using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted.GameModel
{
    public class Ghost : Element
    {
        public Ghost(int x, int y)
        {
            this.area = new System.Drawing.Rectangle();
        }
    }
}
