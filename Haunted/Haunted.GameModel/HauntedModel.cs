// <copyright file="HauntedModel.cs" company="PlaceholderCompany">
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
    /// haunted model.
    /// </summary>
    public class HauntedModel : IGameModel
    {
        /// <inheritdoc/>
        public bool[,] Walls { get; set; }

        /// <inheritdoc/>
        public GirlPlayer Player { get; set; }

        /// <inheritdoc/>
        public Point Exit { get; set; }

        /// <inheritdoc/>
        public Key Key { get; set; }

        /// <inheritdoc/>
        public double GameWidth { get; set; }

        /// <inheritdoc/>
        public double GameHeight { get; set; }

        /// <inheritdoc/>
        public double TileSize { get; set; }

        /// <summary>
        /// Number of ghosts.
        /// </summary>
        const int numGhost = 5;

        /// <summary>
        /// Lifes.
        /// </summary>
        private int lifeCount = 3;

        /// <summary>
        /// Key numb.
        /// </summary>
        private int numKey = 4;

        /// <summary>
        /// Initializes a new instance of the <see cref="HauntedModel"/> class.
        /// </summary>
        /// <param name="w">widht.</param>
        /// <param name="h">height.</param>
        public HauntedModel(double w, double h)
        {
            this.Keys = new List<Key>();      // ez a kettő a szellem és kulcs randomizer lenne, egyenlőre ezt így hagyom, passz hogy itt kell e megcsinálni vagy nem
            this.Ghosts = new List<Ghost>();
            this.MyTime = new Time(Config.TimePlaceX, Config.TimePlaceY);

            this.Background = new Point[2];
            this.Background[0] = new Point(0, 0);   // ez a 3 bacgroundos még passz hogy mi, egyenlőre itt lesz max áttírjuk ha rájövünk mire jó
            this.Background[1] = new Point(this.GameWidth - 1, 0);
            this.GameWidth = w;
            this.GameHeight = h;
        }

        /// <summary>
        /// Gets ghost numb.
        /// </summary>
        public static int NumGhost
        {
            get { return numGhost; }
        }

        /// <summary>
        /// Gets or sets lives numb.
        /// </summary>
        public int LivesCount { get => this.lifeCount; set => this.lifeCount = value; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        public Time MyTime { get; set; }

        /// <inheritdoc/>
        int IGameModel.NumGhost
        {
            get { return 4; }
        } // randomizerhez a számok, ugye azért 1el kevesebb meet a for ciklus 0-ról indul

        /// <inheritdoc/>
        int IGameModel.NumKey
        {
            get { return 3; }
        }

        /// <inheritdoc/>
        public List<Ghost> Ghosts { get; set; }

        /// <inheritdoc/>
        public List<Key> Keys { get; set; }

        /// <inheritdoc/>
        public Point[] Background { get; set; }
    }
}
