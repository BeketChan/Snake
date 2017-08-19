using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class Snake :Figure
  {
    public Snake(Point tail, int length, Diractions diraction)
    {
      line = new List<Point>();
      for(int n = 0; n < length; n++)
      {
        Point p = new Point(tail);
        p.Move(n, diraction);
        line.Add(p);
      }
    }
  }
}
