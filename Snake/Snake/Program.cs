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
            int x1 = 10;
            int y1 = 10;
            char sym1 = '*';

            Draw(x1, y1, sym1);

            int x2 = 20;
            int y2 = 20;
            char sym2 = 'J';

            Draw(x2, y2, sym2);
            

            Console.ReadLine();
        }
        static void Draw (int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
    }
}
}
