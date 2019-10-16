using System;

namespace GetMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a word:");
            string s = Console.ReadLine();
            Console.WriteLine("Your words middle char is :" + GetMiddle(s));
            Console.ReadKey();
        }

        public static string GetMiddle(string s)
        {
            string middle;

            if (s.Length % 2 == 0)
            {
                middle = s.Substring(s.Length / 2 - 1, 2);

                return middle;
            }
            else
            {
                middle = s.Substring(s.Length / 2, 1);

                return middle;
            }
        }
    }
}
