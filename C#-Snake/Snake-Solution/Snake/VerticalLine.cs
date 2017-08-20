using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class VerticalLine : Figure
  {
    public VerticalLine(int yTop, int yBotton, int x, char sym)
    {
      line = new List<Point>();
      for (int n = yTop; n <= yBotton; n++)
      {
        Point p = new Point(x, n, sym);
        line.Add(p);
      }
    }


    public override void Drow()
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      base.Drow();
      Console.ForegroundColor = ConsoleColor.White;
    }
  }
}
