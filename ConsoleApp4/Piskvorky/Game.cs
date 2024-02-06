using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.NewFolder
{
    public class Game
    {
        public void Piskvorky()
        {
            Console.WriteLine("ENTER - zapsani, ovladate sipkami, ESC - konec");
            Console.WriteLine("---");
            Console.WriteLine("Napiste tloustku pole:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Napiste velikost pole:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Table table = new Table(a, b);
            while (true)
            {
                table.Draw();
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Escape)
                {
                    break;
                }
                table.HandleKey(info.Key);
                if (table.Winner == 0) { }
                else
                if (table.Winner == 3) // remíza
                {
                    Console.WriteLine("Remíza");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(table.Winner + ". hráč vyhrál, enter pro konec");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
