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
      Snake snake = new Snake(p, 3, Diractions.RUGHT);
      snake.Drow();
      snake.Move();
      Thread.Sleep(300);
      snake.Drow();
      snake.Move();
      Thread.Sleep(300);
      snake.Drow();
      snake.Move();
      Thread.Sleep(300);
      snake.Drow();
      snake.Move();
      Thread.Sleep(300);
      snake.Drow();
      snake.Move();
      Thread.Sleep(300);


      Console.ReadKey();
    }
  }
}
