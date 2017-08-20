using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class FoodCreator
  {
    int mapHeaght;
    int mapWidth;
    char sym;
    Random rnd = new Random();

    public FoodCreator(int h, int w, char s)
    {
      mapHeaght = h;
      mapWidth = w;
      sym = s;
    }

    public Point CreateFood()
    {
      int x = rnd.Next(2, mapWidth - 4);
      int y = rnd.Next(2, mapHeaght - 2);
      return new Point(x, y, sym);
    }
  }
}
