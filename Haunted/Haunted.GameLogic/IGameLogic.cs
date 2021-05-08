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
    using Haunted.GameModel;

    /// <summary>
    /// Igame logic.
    /// </summary>
    public interface IGameLogic
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
        /// <returns>point.</returns>
        public Point GetTilePos(Point mousePos);

        /// <summary>
        /// New score adding method.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="time">Score.</param>
        public void NewTime(string name, TimeSpan time);

        /// <summary>
        /// Score listing method.
        /// </summary>
        /// <returns>A list.</returns>
        public List<TimeToXML> ListTime();
    }
}
