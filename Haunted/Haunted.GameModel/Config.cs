using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted.GameModel
{
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
        public static double GhostHeight;
        public static double GhostWidth;
        public static double GhostSpeed; //(egyenlőre csak 1 sebesség))
        //player
        public static double PlayerWidth;
        public static double PlayerHeight;
        //játék
        public static double GameWidth;
        public static double GameHeight;
        //kulcs
        public static double KeyPlaceX;
        public static double KeyPlaceY;
        public static double KeySize;
    }
}
