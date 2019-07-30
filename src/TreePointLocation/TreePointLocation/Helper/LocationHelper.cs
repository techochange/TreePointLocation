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
            var D1 = -2 * p1.X;
            var D2 = -2 * p2.X;
            var D3 = -2 * p3.X;

            var E1 = -2 * p1.Y;
            var E2 = -2 * p2.Y;
            var E3 = -2 * p3.Y;

            var F1 = Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2) - Math.Pow(p1.Distance, 2);
            var F2 = Math.Pow(p2.X, 2) + Math.Pow(p2.Y, 2) - Math.Pow(p2.Distance, 2);
            var F3 = Math.Pow(p3.X, 2) + Math.Pow(p3.Y, 2) - Math.Pow(p3.Distance, 2);

            double x = 0, y = 0;

            //万一是除以0 会得到NaN(无穷大)
            if (((E3 - E1) * (D1 - D2) - (E2 - E1) * (D1 - D3)) != 0)
            {
                y = ((F2 - F1) * (D1 - D3) - (F3 - F1) * (D1 - D2)) / ((E3 - E1) * (D1 - D2) - (E2 - E1) * (D1 - D3));
            }

            //同理,万一是除以0  会得到NaN(无穷大)
            if (D1 != D3)
            {
                x = ((E3 - E1) * y + F3 - F1) / (D1 - D3);
            }
            else if (D1 != D2)
            {
                x = ((E2 - E1) * y + F2 - F1) / (D1 - D2);
            }
            // 如果: D1 == D3 == D2 三个固定点在一条直线上
            // 此时 返回 x=0 y=0

            Point P = new Point() { X = x, Y = y, Distance = 0 };
            return P;
        }
    }
}
