using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreePointLocation.Model
{
    public class Point
    {
        /// <summary>
        /// x坐标值
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// y坐标值
        /// </summary>
        public double Y { get; set; }
        /// <summary>
        /// 欲求解的点到 这个点的距离
        /// </summary>
        public double Distance { get; set; }
    }
}
