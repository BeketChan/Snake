using System;
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

    internal bool IsHitTail()
    {
      Point head = line.Last();
      for(int i = 0; i < line.Count - 2; i++)
      {
        if (head.IsHit(line[i]))
        {
          return true;
        }
      }
      return false;
    }

    public void HandleKey(ConsoleKey key)
    {
      switch (key)
      {
        case ConsoleKey.UpArrow:
          diraction = Diractions.UP;
          break;
        case ConsoleKey.DownArrow:
          diraction = Diractions.DOUN;
          break;
        case ConsoleKey.LeftArrow:
          diraction = Diractions.LEFT;
          break;
        case ConsoleKey.RightArrow:
          diraction = Diractions.RUGHT;
          break;
      }
    }

    internal bool Eat(Point food)
    {
      Point head = GetNewPoint();
      if (head.IsHit(food))
      {
        food.sym = head.sym;
        food.Drow();
        line.Add(food);
        return true;
      }
      else return false;
    }
  }
}
