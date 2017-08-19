using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class Program
  {
    static void Main(string[] args)
    {
      HorizontalLine hor1 = new HorizontalLine(3, 7, 5, '+');
      hor1.Drow();

      VerticalLine ver1 = new VerticalLine(3, 7, 5, '+');
      ver1.Drow();

      Console.ReadKey();
    }
  }
}
