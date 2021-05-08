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
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TimeSpan Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="time"></param>
        public TimeToXML(string name, TimeSpan time)
        {
            this.Name = name;
            this.Time = time;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Player name: {this.Name}\nTime: {this.Time}";
        }
    }
}
