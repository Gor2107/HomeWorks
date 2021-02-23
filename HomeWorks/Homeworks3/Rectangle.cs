using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks3
{
    #region Rectangle#
    public struct Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public struct Rectangle
    {
        public Point TopLeftPoint { get; set; }
        public Point TopRightPoint { get; set; }

        public Point BottomLeftPoint { get; set; }
        public Point BottomRightPoint { get; set; }

        private int Width { get;  }
        private int Height { get; }

        public Rectangle(int weight, int height, int x, int y)
        {
            this.TopLeftPoint = new Point(x, y);
            this.TopRightPoint = new Point(x + weight, y);
            this.BottomLeftPoint = new Point(x, y - height);
            this.BottomRightPoint = new Point(x + weight, y - height);
            this.Width = weight;
            this.Height = height;
        }
        public void ChangePoints(int x, int y)
        {
            this.TopLeftPoint = new Point(x, y);
            this.TopRightPoint = new Point(x + this.Width, y);
            this.BottomLeftPoint = new Point(x, y - this.Height);
            this.BottomRightPoint = new Point(x + this.Width, y - this.Height);
        }
        /// <summary>
        /// Checks whether the given rectangle is overlapping with current rectangle or not
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool CheckLappingRectangles(Rectangle r)
        {
            if ((this.TopRightPoint.y >= r.BottomLeftPoint.y && this.TopRightPoint.x >= r.BottomLeftPoint.x
                && this.TopLeftPoint.x <= r.BottomLeftPoint.x) ||   //overlapping case 1
                (r.TopRightPoint.y >= this.BottomLeftPoint.y && r.TopRightPoint.x >= this.BottomLeftPoint.x
                && r.TopLeftPoint.x <= this.BottomLeftPoint.x) ||   //overlapping case 1 reversed rectangles
                (this.BottomRightPoint.y <= r.TopLeftPoint.y && this.BottomRightPoint.x >= r.TopLeftPoint.x
                && this.BottomLeftPoint.x < r.TopLeftPoint.x) ||     //overlapping case 2
                (r.BottomRightPoint.y <= this.TopLeftPoint.y && r.BottomRightPoint.x >= this.TopLeftPoint.x
                && r.BottomLeftPoint.x < this.TopLeftPoint.x) ||   //overlapping case 2 reversed rectangles
                (this.TopRightPoint.y >= r.TopRightPoint.y && this.TopRightPoint.x >= r.TopRightPoint.x && this.TopLeftPoint.x <= r.TopLeftPoint.x &&
                 this.BottomLeftPoint.y <= r.TopLeftPoint.y) ||//overlapping case 3
                (r.TopRightPoint.y >= this.TopRightPoint.y && r.TopRightPoint.x >= this.TopRightPoint.x && r.TopLeftPoint.x <= this.TopLeftPoint.x &&
                 r.BottomLeftPoint.y <= this.TopLeftPoint.y))//overlapping case 3 reversed
            {
                return true;
            }


            return false;
        }

    }
    #endregion
}
