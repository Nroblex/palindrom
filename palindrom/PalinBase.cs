using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    public abstract class PalinBase
    {
        private int PalinCounter = 0;

        protected PalinBase(Object param)
        {
            if (param.GetType() == typeof(int))
            {
                RunPalindrom((int)param);
            }
            else
            {
                RunPalindromText(param.ToString());
            }
        }

        private bool IsPalindrom(char[] original, char[] copy)
        {
            for (int n = 0; n <= original.Length - 1; n++)
            {
                if (original[n] != copy[n])
                    return false;
            }

            PalinCounter++;
            return true;
        }

        public void RunPalindrom(int MaxValue)
        {
            string val = String.Empty;
            for (int n = 10; n <= MaxValue; n++)
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

            Console.WriteLine("Found total of {0} palindrome", PalinCounter.ToString());

        }
        public void RunPalindromText(string FilePath)
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("Filepath does not exist.");
                return;
            }

            List<String> FileRows = File.ReadAllLines(FilePath).ToList();

            List<String> words = new List<string>();
            foreach (String str in FileRows)
            {
                if (str.Length == 0)
                    continue;

                words = str.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (string word in words)
                {
                    if (word.Length < 2)
                        continue;

                    var a = word.Replace(".", "").ToCharArray();
                    char[] cp = new char[a.Length];

                    Array.Copy(a, cp, a.Length);

                    Array.Reverse(cp);

                    if (IsPalindrom(a, cp))
                    {
                        Console.WriteLine("Found palindrom: {0}", new String(a));
                    }

                }
            }

            Console.WriteLine("Found total of {0} palindrome", PalinCounter.ToString());
        }
    }
}
