using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreePointLocation.Model;

namespace TreePointLocation
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point() { X = 2, Y = 3, Distance = Math.Sqrt(10) };
            Point p2 = new Point() { X = 1, Y = 1, Distance = Math.Sqrt(5) };
            Point p3 = new Point() { X = 2, Y = 1, Distance = Math.Sqrt(10) };

            var p = TreePointLocation.Helper.LocationHelper.LocationByThree(p1, p2, p3);

            Console.WriteLine("Point x:{0}", p.X);
            Console.WriteLine("Point y:{0}", p.Y);
            Console.ReadKey();
        }
    }
}
