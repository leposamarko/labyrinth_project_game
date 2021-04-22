// <copyright file="IGameLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.GameLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;

    /// <summary>
    /// Igame logic.
    /// </summary>
    internal interface IGameLogic
    {
        /// <summary>
        /// character move method.
        /// </summary>
        /// <param name="dx">x coordinate.</param>
        /// <param name="dy">y coordinate.</param>
        /// <returns>can moove.</returns>
        public bool Move(int dx, int dy);

        /// <summary>
        /// initmodel.
        /// </summary>
        /// <param name="fname">file name.</param>
        public void Initmodel(string fname);

        /// <summary>
        /// get the position to title.
        /// </summary>
        /// <param name="mousePos">mouse position.</param>
        /// <returns>point</returns>
        public Point GetTilePos(Point mousePos);
    }
}
