using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class Point
  {
    public int x;
    public int y;
    public char sym;

    public Point() {}

    public Point(int _x,int _y,char _sym)
    {
      x = _x;
      y = _y;
      sym = _sym;
    }

    public Point(Point p)
    {
      x = p.x;
      y = p.y;
      sym = p.sym;
    }

    public void Move(int ofset, Diractions dir)
    {
      switch (dir)
      {
        case Diractions.UP:
          y -= ofset;
          break;
        case Diractions.DOUN:
          y += ofset;
          break;
        case Diractions.LEFT:
          x -= ofset;
          break;
        case Diractions.RUGHT:
          x += ofset;
          break;
      }
    }

    internal void Clear()
    {
      sym = ' ';
      Drow();
    }

    public void Drow()
    {
      Console.SetCursorPosition(x, y);
      Console.Write(sym);
    }

    internal bool IsHit(Point p)
    {
      return p.x == x && p.y == y;
    }

    /*public override string ToString()
    {
      return x + "," + y + "," + sym;
    }*/
  }
}
