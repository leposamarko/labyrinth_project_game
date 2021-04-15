using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted.GameModel
{
    class GirlPlayer :Element
    {
        public GirlPlayer()
        {
            this.area = new Rectangle();
        }
        public List<TimeToXML> Scores { get; set; }
    }
}
