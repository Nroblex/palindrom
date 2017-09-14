using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        static Palindrome palindrom;
        static void Main(string[] args)
        {
            int nMax = 0;
            if (args.Length == 0)
            {
                Console.Write("Enter maxvalue to test: ");
                String Max = Console.ReadLine();

                Int32.TryParse(Max, out nMax);

                if (nMax == 0)
                {
                    Console.WriteLine("Enter a proper integer value!");
                    return;
                }
            }

            palindrom = new Palindrome(nMax);
            palindrom.Run();

            Console.ReadKey();
        }
    }

    class Palindrome
    {
        public int MaxValue { get; set; }

        public Palindrome(int max)
        {
            MaxValue = max;
        }

        internal void Run()
        {
            string val = String.Empty;
            for (int n = 10; n<=MaxValue; n++)
            {
                var v = n.ToString().ToCharArray();
                char[] cp = new char[v.Length];

                Array.Copy(v, cp, v.Length);
                Array.Reverse(v);

                if (IsPalindrom(cp, v))
                {
                    Console.WriteLine("Palindrom found => {0} ", new string(cp));
                }
            }
        }

        internal bool IsPalindrom(char[] orig, char[] reverse)
        {
            //1991
            for (int n = 0; n<=orig.Length-1; n++)
            {
                if (orig[n] != reverse[n])
                    return false;
            }

            return true;
        }
    }
}
