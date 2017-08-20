using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.SetWindowSize(1, 1);
      Console.SetBufferSize(80, 25);
      Console.SetWindowSize(80, 25);

      // рамочка
      HorizontalLine upLine = new HorizontalLine(1, 78, 0, '+');
      HorizontalLine downLine = new HorizontalLine(1, 78, 24, '+');
      VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
      VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
      upLine.Drow();
      downLine.Drow();
      leftLine.Drow();
      rightLine.Drow();

      // старт змейки
      Point p = new Point(4, 5, '*');
      Figure fsnake = new Snake(p, 3, Diractions.RUGHT);
      fsnake.Drow();
      Snake snake = (Snake)fsnake;

      FoodCreator foodCreator = new FoodCreator(25, 80, '$');
      Point food = foodCreator.CreateFood();
      food.Drow();

      while (true)
      {
        if (snake.Eat(food))
        {
          food = foodCreator.CreateFood();
          food.Drow();
        }
        else
        {
          snake.Move();
        }

        Thread.Sleep(100);

        if (Console.KeyAvailable)
        {
          ConsoleKeyInfo keyInfo = Console.ReadKey();
          snake.HandleKey(keyInfo.Key);
        }
      }

      Console.ReadKey();
    }
  }
}
