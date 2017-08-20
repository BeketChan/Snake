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
      Walls walls = new Walls(80, 25);
      walls.Drow();

      // старт змейки
      Point p = new Point(4, 5, '*');
      Figure fsnake = new Snake(p, 3, Diractions.RUGHT);
      fsnake.Drow();
      Snake snake = (Snake)fsnake;

      // кидаем еду
      FoodCreator foodCreator = new FoodCreator(25, 80, '$');
      Point food = foodCreator.CreateFood();
      food.Drow();

      while (true)
      {
        if(walls.IsHit(snake) || snake.IsHitTail())
        {
          break;
        }

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

      Console.Write("ВЫ проиграли !");
      Console.ReadKey();
    }
  }
}
