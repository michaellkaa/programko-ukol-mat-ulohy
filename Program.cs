using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptackova_mat_ulohy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte požadavek: (a- obvod kruhu, b- odmocnina, c- mocnina, d- obvod a obsah čtverce)");
            char volba = char.Parse(Console.ReadLine());

            if (volba == 'a')
            {
                Console.WriteLine("Vybrali jste si možnost 'obvod kruhu'");
                Console.WriteLine("Zadejte poloměr kruhu: ");
                int r = Convert.ToInt32(Console.ReadLine());
                double vysledek = 2 * Math.PI * r;
                Console.WriteLine("Výsledek: " + vysledek);
            }
            else if (volba == 'b')
            {
                Console.WriteLine("Vybrali jste si možnost 'výpočet odmocniny'");
                Console.WriteLine("Zadejte číslo pro výpočet druhé odmocniny: ");
                double x = double.Parse(Console.ReadLine());
                if (x >= 0)
                {
                    double vysledek = Math.Sqrt(x);
                    Console.WriteLine("Výsledek: " + vysledek);
                }
                else
                {
                    Console.WriteLine("Hodnota musí být větší než nula");
                }

            }
            else if (volba == 'c')
            {
                Console.WriteLine("Vybrali jste si možnost 'výpočet mocniny'");
                Console.WriteLine("Zadejte základ čísla (x): "); // x na y (5 na 2)
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Zadej exponent (y): ");
                double n = double.Parse(Console.ReadLine());
                double vysledek = Math.Pow(x, n);
                Console.WriteLine("Výsledek: " + vysledek);
            }
            else if (volba == 'd')
            {
                Console.WriteLine("Vybrali jste si možnost 'výpočet obvodu a obsahu čtverce'");
                Console.WriteLine("Zadejte délku strany a v cm: ");
                double a = double.Parse(Console.ReadLine());
                if (a > 0)
                {
                    double vysledek1 = 4 * a;
                    double vysledek2 = a * a;
                    Console.WriteLine("Obvod čverce: " + vysledek1 + "cm");
                    Console.WriteLine("Obsah čverce: " + vysledek2 + "cm^2");
                }
                else
                {
                    Console.WriteLine("Hodnota musí být větší než nula");
                }

            }
            else
            {
                Console.WriteLine("zadejte jen jeden znak z možností a, b, c, d");
            }
            Console.ReadKey();
        }
    }
}
