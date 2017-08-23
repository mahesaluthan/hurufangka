using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class echa
    {
        public void Echasmith(params int[] echa)
        {
            foreach (int i in echa)
            {
                Console.WriteLine("Echasmith {0}", i);
            }
        }
        static void Main()
        {
            echa e = new echa();
            e.Echasmith(5, 6, 7, 8);
            int[] explicitArray = new int[5] { 1, 2, 3, 4, 5 };
            e.Echasmith(explicitArray);

            Console.ReadKey();
        }
    }
}
