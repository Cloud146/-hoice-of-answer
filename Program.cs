using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сhoice_of_answer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбор 1: ");
            int top1 = Console.CursorTop;
            int z1 = top1;
            Console.WriteLine("1 Да");
            Console.WriteLine("2 Нет");
            int down1 = Console.CursorTop;
            Select.Choise(ref top1, ref z1, ref down1);
            if (z1 == top1)
                Console.WriteLine("Да");
            else if (z1 == top1 + 1)
                Console.WriteLine("Нет");
        }
    }



    class Select
    {
        public static void Choise(ref int top, ref int y, ref int down)
        {
            Console.CursorSize = 100;
            Console.CursorTop = top;
            ConsoleKey key;
            while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter)
            {
                if (key == ConsoleKey.UpArrow)
                {
                    if (y > top)
                    {
                        y--;
                        Console.CursorTop = y;
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    if (y < down - 1)
                    {
                        y++;
                        Console.CursorTop = y;
                    }
                }
            }
            Console.CursorTop = down;
        }

    }
}
