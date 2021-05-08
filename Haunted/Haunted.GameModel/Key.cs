// <copyright file="Key.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.GameModel
{
    using System.Windows;

    /// <summary>
    /// The Key element.
    /// </summary>
    public class Key : Element
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Key"/> class.
        /// </summary>
        /// <param name="x">X parameter.</param>
        /// <param name="y">Y parameter.</param>
        public Key(double x, double y)
        {
            this.area = new Rect(x, y, Config.KeySize, Config.KeySize);
        }
    }
}
