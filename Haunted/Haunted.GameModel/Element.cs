// <copyright file="Element.cs" company="PlaceholderCompany">
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
    /// main element.
    /// </summary>
    public class Element
    {
        /// <summary>
        /// area.
        /// </summary>
        protected Rect area;

        /// <summary>
        /// Gets area.
        /// </summary>
        public Rect Area
        {
            get { return this.area; }
        }

        /// <summary>
        /// Gets get points.
        /// </summary>
        public Point GetPoints { get { return new Point(this.area.X, this.area.Y); } }

        /// <summary>
        /// change x.
        /// </summary>
        /// <param name="x">x coordinate.</param>
        public void ChangeX(int x)
        {
            this.area.X += x;
        }

        /// <summary>
        /// change y.
        /// </summary>
        /// <param name="y">y coordinate.</param>
        public void ChangeY(int y)
        {
            this.area.Y += y;
        }

        /// <summary>
        /// set position.
        /// </summary>
        /// <param name="x">x coordinate.</param>
        /// <param name="y">y coordinate.</param>
        public void SetPosition(int x, int y)
        {
            this.area.X = x;
            this.area.Y = y;
        }
    }
}
