using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class Program
  {
    static void Main(string[] args)
    {
      Point p1 = new Point(1, 1, '*');
      Point p2 = new Point(1, 2, '*');
      Point p3 = new Point(1, 2, '*');
      Point p4 = new Point(2, 2, '*');
      Point p5 = new Point(3, 2, '*');
      Point p6 = new Point(3, 3, '*');

      List<Point> pointsList = new List<Point>();
      pointsList.Add(p1);
      pointsList.Add(p2);
      pointsList.Add(p3);
      pointsList.Add(p4);
      pointsList.Add(p5);
      pointsList.Add(p6);

      foreach(Point p in pointsList)
      {
        p.Drow();
      }

      Console.ReadKey();
    }
  }
}
