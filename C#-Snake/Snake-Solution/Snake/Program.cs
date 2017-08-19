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
      /*int x = 1;
      Func1(x);
      Console.WriteLine("Func1(x) = " + x);

      x = 1;
      Func2(x);
      Console.WriteLine("Func2(x) = " + x);

      x = 1;
      Func3(x);
      Console.WriteLine("Func3(x) = " + x);*/

      Point p1 = new Point(1, 3, '*');
      p1.Drow();
      Move(p1, 10, 10);
      p1.Drow();

      Point p2 = new Point(4, 5, '#');
      p2.Drow();
      Reset(p2);
      p2.Drow();

      Console.ReadKey();
    }

    static void Func1(int value){}

    static void Func2(int value)
    {
      value++;
    }

    static void Func3(int x)
    {
      x++;
    }

    static void Move(Point p, int dx, int dy)
    {
      p.x += dx;
      p.y += dy;
    }

    static void Reset(Point p)
    {
      p = new Point();
    }

  }
}
