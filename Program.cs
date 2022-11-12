using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace цикл_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<9; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
