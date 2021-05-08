// <copyright file="GirlPlayer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.GameModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;

    /// <summary>
    /// player class.
    /// </summary>
    public class GirlPlayer : Element
    {

        /// <summary>
        /// number of keys at the player.
        /// </summary>
        public int NumbKeys = 0;

        /// <summary>
        /// number of life.
        /// </summary>
        public int Life = 3;

        /// <summary>
        /// Initializes a new instance of the <see cref="GirlPlayer"/> class.
        /// </summary>
        /// <param name="x">x coordinate.</param>
        /// <param name="y">y coordinate.</param>
        public GirlPlayer(int x, int y)
        {
            this.area = new Rect(x, y, Config.PlayerWidth, Config.PlayerHeight);
        }

        /// <summary>
        /// Gets or sets time.
        /// </summary>
        public List<TimeToXML> Times { get; set; }
   }
}
