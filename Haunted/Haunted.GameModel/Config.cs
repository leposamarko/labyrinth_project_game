// <copyright file="Config.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.GameModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// config file.
    /// </summary>
    public class Config // ezeknek még értéket kell adni
    {
        // sziv

        /// <summary>
        /// X.
        /// </summary>
        public static double HeartPlaceX;

        /// <summary>
        /// Y.
        /// </summary>
        public static double HeartPlaceY;

        /// <summary>
        /// Size.
        /// </summary>
        public static double HeartSize;

        // stopper

        /// <summary>
        /// X.
        /// </summary>
        public static double TimePlaceX;

        /// <summary>
        /// Y.
        /// </summary>
        public static double TimePlaceY;

        /// <summary>
        /// Size.
        /// </summary>
        public static double TimeTextSize;

        // szellem

        /// <summary>
        /// Height.
        /// </summary>
        public static double GhostHeight = 40;

        /// <summary>
        /// Widht.
        /// </summary>
        public static double GhostWidth = 40;

        /// <summary>
        /// Speed.
        /// </summary>
        public static double GhostSpeed; // (egyenlőre csak 1 sebesség))

        // player

        /// <summary>
        /// Widht.
        /// </summary>
        public static double PlayerWidth = 40;

        /// <summary>
        /// Height.
        /// </summary>
        public static double PlayerHeight = 40;

        // játék

        /// <summary>
        /// Key size.
        /// </summary>
        public static double KeySize = 30;
    }
}
