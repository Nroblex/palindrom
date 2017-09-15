using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class TextPalindrom : PalinBase
    {
        private List<String> fileRows;
       
        public TextPalindrom(string InputFile)
        {
            fileRows = File.ReadAllLines(InputFile).ToList();
            RunPalindromText(fileRows);

        }

        /*
        public void Run()
        {
            List<String> words = new List<string>();
            foreach (String str in fileRows)
            {
                if (str.Length == 0)
                    continue;

                words = str.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach(string word in words)
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
        */

    }
}
