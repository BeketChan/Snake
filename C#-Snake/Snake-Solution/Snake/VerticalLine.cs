﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class VerticalLine
  {
    public List<Point> line;

    public VerticalLine(int yTop, int yBotton, int x, char sym)
    {
      line = new List<Point>();
      for (int n = yTop; n <= yBotton; n++)
      {
        Point p = new Point(x, n, '+');
        line.Add(p);
      }
    }

    public void Drow()
    {
      foreach (Point p in line)
      {
        p.Drow();
      }
    }
  }
}
