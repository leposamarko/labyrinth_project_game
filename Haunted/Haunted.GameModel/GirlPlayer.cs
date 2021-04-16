using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted.GameModel
{
    public class GirlPlayer :Element
    {
        public GirlPlayer()
        {
            this.area = new Rect(0, 0, Config.PlayerWidth, Config.PlayerHeight); //egyenlőre 0,0 mert nemtudom, hogy kell az indulási helyet beállítani/ranndomizálni.
        }
        public List<TimeToXML> Times { get; set; }
    }
}
