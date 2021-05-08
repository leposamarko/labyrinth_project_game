// <copyright file="TimeToXML.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.GameModel
{
    using System;

    /// <summary>
    /// Time to xml.
    /// </summary>
    public class TimeToXML
    {
        /// <summary>
        /// The name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The time.
        /// </summary>
        public TimeSpan Time { get; set; }

        /// <summary>
        /// Override the ToString.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return $"Player name: {this.Name}\nTime: {this.Time}";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeToXML"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="time">the time.</param>
        public TimeToXML(string name, TimeSpan time)
        {
            this.Name = name;
            this.Time = time;
        }
    }
}
