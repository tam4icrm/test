using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] A = { "1", "22", "333", "4444", "555", "66", "7" };
            foreach (string a in A.Where(element => element.Length > 2))
            {
                Console.WriteLine(a);
            }

           var bbb=  A.Select(element =>
            {
                if (element.Length > 2)
                {
                    Console.WriteLine(element);
                }

                return true;
            });

           var d = bbb.ToArray();

            Console.ReadKey();
        }


    }
}
