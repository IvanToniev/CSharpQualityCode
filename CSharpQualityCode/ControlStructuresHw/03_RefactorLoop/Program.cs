using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RefactorLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int  i = 0; i < 100; i++)
            {
                if (i % 10 == 0 && array[i]==expectedValue)
                {
                    i = 666;
                }

                Console.WriteLine(array[i]);
                //more code
                if (i == 666)
                {
                    Console.WriteLine("Value Found.");
                }
            }
        }
    }
}
