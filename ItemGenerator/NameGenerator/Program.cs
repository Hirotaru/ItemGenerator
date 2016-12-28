using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                WordChain.Create();

                Console.WriteLine(" " + WordChain.GetName(true));
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
