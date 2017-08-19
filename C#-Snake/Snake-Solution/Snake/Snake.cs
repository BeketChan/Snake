﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class Snake :Figure
  {
    Diractions diraction;

    public Snake(Point tail, int length, Diractions _diraction)
    {
      line = new List<Point>();
      for(int n = 0; n < length; n++)
      {
        Point p = new Point(tail);
        p.Move(n, _diraction);
        line.Add(p);
        diraction = _diraction;
      }
    }

    internal void Move()
    {
      Point tail = line.First();
      line.Remove(tail);
      Point head = GetNewPoint();
      line.Add(head);

      tail.Clear();
      head.Drow();
    }

    private Point GetNewPoint()
    {
      Point head = line.Last();
      Point nextPoint = new Point(head);
      nextPoint.Move(1, diraction);
      return nextPoint;
    }
  }
}