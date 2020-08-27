using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class END
    {
        int x;
        int y;
        int scr;
        public END(int x, int y, int scr)
        {
            this.x = x;
            this.y = y;
            this.scr = scr;
        }
        public void DrawEnd()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x, y);
            Console.Write("####GAME OVER####");
            Console.SetCursorPosition(x+6, y+1);
            Console.Write("Press any button to continue");
            Console.SetCursorPosition(x+3, y + 2);
            Console.Write("Score:{0}", scr);
        }
    }
}
