using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeathValley.Models
{
    public class Point
    {
        public int PointId { get; set; }
        public int ChartID { get; set; }
        public int PointX { get; set; }
        public int PointY { get; set; }
        public override string ToString()
        {
            return $"[{PointX}, {PointY}],";
        }
    }
}