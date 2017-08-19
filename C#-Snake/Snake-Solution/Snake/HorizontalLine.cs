using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class HorizontalLine
  {
    public List<Point> line;

    public HorizontalLine(int xLeft, int xRight, int y, char sym)
    {
      line = new List<Point>();
      for(int n = xLeft; n <= xRight; n++)
      {
        Point p = new Point(n, y, '+');
        line.Add(p);
      }
    }

    public void Drow()
    {
      foreach(Point p in line)
      {
        p.Drow();
      }
    }
  }
}
