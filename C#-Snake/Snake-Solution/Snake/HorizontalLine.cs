using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class HorizontalLine :Figure
  {
    public HorizontalLine(int xLeft, int xRight, int y, char sym)
    {
      line = new List<Point>();
      for(int n = xLeft; n <= xRight; n++)
      {
        Point p = new Point(n, y, sym);
        line.Add(p);
      }
    }

    public override void Drow()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      base.Drow();
      Console.ForegroundColor = ConsoleColor.White;
    }
  }
}
