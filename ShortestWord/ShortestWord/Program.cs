using System;
using System.Linq;

namespace ShortestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindShort("Tutaj wpisz swój tekst a znajdę Ci długość najkrótszego słowa"));
            Console.ReadKey();
        }

        public static int FindShort(string s)
        {
           String [] elements = s.Split();
           int [] wordlength = new int[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                wordlength[i] = elements[i].Length;
                
            }

            return wordlength.Min();
        }
    }
}
