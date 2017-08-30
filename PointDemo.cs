using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    struct Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
    class PointDemo
    {
        public static void Main()
        {
            Point p1;
            Point p2 = new Point(1, 2);

            p1.x = 10;
            p1.y = 20;

            Console.WriteLine("{0} {1}", p1.x, p1.y);
            Console.WriteLine("{0} {1}", p2.x, p2.y);

            Init(p1);  // Struct is passed by value so p1 will not be changed 
            Console.WriteLine("{0} {1}", p1.x, p1.y);
        }

        public static void Init(Point p)
        {
            p.x = 0;
            p.y = 0;
        }
    }
}
