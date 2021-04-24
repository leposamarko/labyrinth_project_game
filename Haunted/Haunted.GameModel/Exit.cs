using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Haunted.GameModel
{
    class Exit : Element
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Exit"/> class.
        /// </summary>
        /// <param name="x">x coordinate.</param>
        /// <param name="y">y coordinate.</param>
        public Exit(int x, int y)
        {
            this.area = new Rect(x, y, Config.PlayerWidth, Config.PlayerHeight); //egyenlőre 0,0 mert nemtudom, hogy kell az indulási helyet beállítani/ranndomizálni.
        }
    }
}
