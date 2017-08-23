using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Huruf;
            int angka;

            Console.Write("input: ");
            Huruf = Console.ReadLine();
            angka = int.Parse(Console.ReadLine());


            Console.WriteLine("Itu adalah huruf");
            /*if (Huruf >= 'A' && Huruf <= 'Z' )
            {
                Console.WriteLine("Itu adalah huruf kapital");
            }
            else if (Huruf >= 'a' && Huruf <= 'z')
            {
                Console.WriteLine("Itu adalah huruf kecil ");
            }*/
             if (angka >= '0' && angka <= '9' )
            {
                Console.WriteLine("Itu adalah angka");
            }
            else
            {
                Console.WriteLine("itu adalah simbol");
            }

            Console.ReadLine();
        }
    }
}
