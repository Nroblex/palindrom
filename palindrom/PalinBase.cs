using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    public abstract class PalinBase
    {
        public bool IsPalindrom(char[] original, char[] copy)
        {
            for (int n = 0; n <= original.Length - 1; n++)
            {
                if (original[n] != copy[n])
                    return false;
            }

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
        }
        public void RunPalindromText(List<String> FileRows)
        {
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
        }
    }
}
