using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreePointLocation.Model;

namespace TreePointLocation.Helper
{
    public class LocationHelper
    {
        /// <summary>  
        /// 三点定位
        /// 根据圆的函数展开式（详见readme）
        /// 得到如下代码
        /// </summary>  
        public static Point LocationByThree(Point p1, Point p2, Point p3)
        {
            Point P = new Point() { X = 0 Y =0, Distance = 0 };
            return P;
        }
    }
}
