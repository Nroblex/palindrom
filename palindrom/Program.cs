using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program 
    {
        static void Main(string[] args)
        {
            int nMax = 0;
            string PathTextfile = null;
            if (args.Length == 0)
            {
                Console.WriteLine(" Give -f for textfile or -n for numbers");
                return;
            }

            if (args[0].CompareTo("-f") == 0)
            {
                Console.WriteLine("Input textfile: ");
                PathTextfile = Console.ReadLine();

                new Palindrom(PathTextfile);

            }
            else if (args[0].CompareTo("-n") == 0)
            {
                Console.Write("Enter maxvalue to test: ");
                String Max = Console.ReadLine();

                Int32.TryParse(Max, out nMax);

                if (nMax == 0)
                {
                    Console.WriteLine("Enter a proper integer value!");
                    return;
                }

                new Palindrom(nMax);
                
            }
            else
            {
                Console.WriteLine("Wrong argument.");
                return;
            }

            

            Console.ReadKey();

        }

        

    }


}
