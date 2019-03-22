using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            long b;

            while (true)
            {
                Console.Write("Add meg az első számot: ");
                a = Convert.ToInt64(Console.ReadLine());
                Console.Write("Add meg a második számot: ");
                b = Convert.ToInt64(Console.ReadLine());
                Console.Clear();
                if(a != 0 && b != 0)
                {
                    Console.WriteLine($"A számok amiket beírtál: {a} és {b}.");
                    break;
                }
                else
                {
                    Console.WriteLine("Hibás szám a 0, ezt nem tekintem számnak!");
                }
            }

            while (true)
            {

                long note;

                while (true)
                {
                    Console.WriteLine("Lehetőségek:");
                    Console.WriteLine("1.: Összeadás");
                    Console.WriteLine("2.: Kivonás");
                    Console.WriteLine("3.: Osztás");
                    Console.WriteLine("4.: Szorzás");
                    note = Convert.ToInt64(Console.ReadLine());
                    if (note != 0 && note < 5)
                    {
                        Console.WriteLine("Ezt a lehetőséget választottad: " + note);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("A lehetőség amit választottál nem létezik.");
                    }
                }

                Console.Clear();
                switch (note)
                {
                    case 1:
                        Console.WriteLine($"Az összeadás eredménye : {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"A kivonás eredménye : {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"Az osztás eredménye : {a / b}");
                        break;
                    case 4:
                        Console.WriteLine($"A szorzás eredménye : {a * b}");
                        break;
                }
                Console.WriteLine("Nyomj egy gombot a folytatáshoz!");
                Console.ReadKey();
            }
        }
    }
}