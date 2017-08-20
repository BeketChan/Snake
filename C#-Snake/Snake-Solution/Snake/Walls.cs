using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class Walls : Figure
  {
    List<Figure> WallList;

    public Walls(int mapWidth, int mapHeight)
    {
      WallList = new List<Figure>();

      HorizontalLine upLine = new HorizontalLine(1, mapWidth - 2, 0, '#');
      HorizontalLine downLine = new HorizontalLine(1, mapWidth - 2, mapHeight - 1, '#');
      VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '#');
      VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '#');

      WallList.Add(upLine);
      WallList.Add(downLine);
      WallList.Add(leftLine);
      WallList.Add(rightLine);
    }

    public override void Drow()
    {
      foreach(Figure wall in WallList)
      {
        wall.Drow();
      }
    }

    internal override bool IsHit(Figure figure)
    {
      foreach(var wall in WallList)
      {
        if (wall.IsHit(figure))
        {
          return true;
        }
      }
      return false;
    }
  }
}
