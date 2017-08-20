using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class Figure
  {
    protected List<Point> line;

    public virtual void Drow()
    {
      foreach (Point p in line)
      {
        p.Drow();
      }
    }

    internal virtual bool IsHit(Figure figure)
    {
      foreach(Point p in line)
      {
        if (figure.IsHit(p))
          return true;
      }
      return false;
    }

    internal virtual bool IsHit(Point point)
    {
      foreach (Point p in line)
      {
        if (p.IsHit(point))
          return true;
      }
      return false;
    }
  }
}
