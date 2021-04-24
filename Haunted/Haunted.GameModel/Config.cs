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
    public class Config //ezeknek még értéket kell adni
    {
        //sziv
        public static double HeartPlaceX;
        public static double HeartPlaceY;
        public static double HeartSize;
        //stopper
        public static double TimePlaceX;
        public static double TimePlaceY;
        public static double TimeTextSize;
        //szellem
        public static double GhostHeight = 40;
        public static double GhostWidth = 40;
        public static double GhostSpeed; //(egyenlőre csak 1 sebesség))
        //player
        public static double PlayerWidth = 40;
        public static double PlayerHeight = 40;
        //játék
        //public static double GameWidth = 1280;
        //public static double GameHeight = 720;
        //kulcs
        //public static double KeyPlaceX;
        //public static double KeyPlaceY;
        public static double KeySize = 30;
    }
}
