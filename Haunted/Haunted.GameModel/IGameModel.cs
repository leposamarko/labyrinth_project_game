// <copyright file="IGameModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.GameModel
{
    using System.Collections.Generic;
    using System.Windows;

    /// <summary>
    /// Interface.
    /// </summary>
    public interface IGameModel // megj.: Az órához stopwatch-ot kell használni, melyet xy.stop() után .elapsed-el el lehet menteni egy timespanbe -> https://stackoverflow.com/questions/13690708/timer-c-sharp-use-in-game-development
    {
        /// <summary>
        /// Gets or sets wall or not.
        /// </summary>
        public bool[,] Walls { get; set; }

        /// <summary>
        /// Gets or sets the player.
        /// </summary>
        public GirlPlayer Player { get; set; }

        /// <summary>
        /// Gets or sets the exit.
        /// </summary>
        public Point Exit { get; set; }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        public Key Key { get; set; }

        /// <summary>
        /// Gets or sets widht.
        /// </summary>
        public double GameWidth { get;  set; } // Pixel size

        /// <summary>
        /// Gets or sets height.
        /// </summary>
        public double GameHeight { get;  set; } // Pixel sizes

        /// <summary>
        /// Gets or sets size of the tile.
        /// </summary>
        public double TileSize { get; set; }

        /// <summary>
        /// Gets or sets counting the lives.
        /// </summary>
        public int LivesCount { get; set; }

        /// <summary>
        /// Gets number of ghosts.
        /// </summary>
        public int NumGhost { get; }

        /// <summary>
        /// Gets number of keys.
        /// </summary>
        public int NumKey { get; }

        /// <summary>
        /// Gets or sets the ghosts.
        /// </summary>
        List<Ghost> Ghosts { get; set; }

        /// <summary>
        /// Gets or sets the keys.
        /// </summary>
        List<Key> Keys { get; set; }

        /// <summary>
        /// Gets or sets the background.
        /// </summary>
        Point[] Background { get; set; }
    }
}