// <copyright file="Exit.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.GameModel
{
    using System.Windows;

    /// <summary>
    /// The exit.
    /// </summary>
    public class Exit : Element
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
