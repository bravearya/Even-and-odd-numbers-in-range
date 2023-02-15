using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication83
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("enter range");
                int a;
                int x = 10;
                string type;
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter (zoje) or (fard)");
                type = Console.ReadLine();
                double c = Math.Pow(x, a);
                for (int range = 0; range < c; range++)
                {
                    if (type == "fard")
                    {
                        if (range % 2 != 0)
                        {
                            string fard = ("fard : " + (range));
                            Console.WriteLine(fard);
                            Console.WriteLine("");
                        }
                    }
                    else if (type == "zoje")
                    {
                        if (range % 2 == 0)
                        {
                            string zoje = ("zoje : " + (range));
                            Console.WriteLine(zoje);
                            Console.WriteLine("");
                        }
                    }

                } Console.ReadKey();
            }





        }
    }
}
