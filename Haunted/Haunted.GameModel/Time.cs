// <copyright file="Time.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.GameModel
{
    using System.Windows;

    /// <summary>
    /// The timme.
    /// </summary>
    public class Time :Element
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        /// <param name="x">X parameter.</param>
        /// <param name="y">Y parameter.</param>
        public Time(double x, double y)
        {
            this.area = new Rect(x, y, Config.TimeTextSize, Config.TimeTextSize);
        }
    }
}
