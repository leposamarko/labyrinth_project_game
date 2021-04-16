﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace Haunted.GameModel
{
    class Element
    {
        protected Rect area;

        public Rect Area { get { return this.area; } }

        public Point GetPoints { get { return new Point(this.area.X, this.area.Y); } }
        public void ChangeX(int x)
        {
            this.area.X += x;
        }
        public void ChangeY(int y)
        {
            this.area.Y += y;
        }
        public void SetPosition(int x, int y)
        {
            this.area.X = x;
            this.area.Y = y;
        }
    }
}
