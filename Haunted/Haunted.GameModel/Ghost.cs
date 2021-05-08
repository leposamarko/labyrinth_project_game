// <copyright file="Ghost.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.GameModel
{
    using System.Windows;

    /// <summary>
    /// The ghost.
    /// </summary>
    public class Ghost : Element
    {
        /// <summary>
        /// Y moving.
        /// </summary>
        public int Movey = 1;

        /// <summary>
        /// X moving.
        /// </summary>
        public int Movex = 1;

        /// <summary>
        /// Move.
        /// </summary>
        public string WhichMove = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ghost"/> class.
        /// </summary>
        /// <param name="x">X.</param>
        /// <param name="y">Y.</param>
        public Ghost(int x, int y)
        {
            this.area = new Rect(x, y, Config.GhostWidth, Config.GhostHeight);
        }
    }
}
