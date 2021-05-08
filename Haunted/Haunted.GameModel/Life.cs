using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Haunted.GameModel
{
    /// <summary>
    /// The life element.
    /// </summary>
    class Life :Element
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Life"/> class.
        /// </summary>
        /// <param name="x">X parameter.</param>
        /// <param name="y">Y parameter.</param>
        public Life(double x, double y)
        {
            this.area = new Rect(x, y, Config.HeartSize, Config.HeartSize);
        }
    }
}
