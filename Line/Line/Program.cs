using System;

namespace Line
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tickets(new int[] { 25, 25, 50, 50, 100 }));
            Console.ReadKey();
        }

        
        public static string Tickets(int[] peopleInLine)
        {
            int cashAvailable = 0;
            for (int i = 1; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[0] > 25)
                {
                    return "NO";
                }

                cashAvailable = cashAvailable + peopleInLine[i-1]; 
                 
                if (cashAvailable < peopleInLine[i])
                {
                    return "NO";
                }

                if (peopleInLine[i] > 25)
                {
                    cashAvailable = cashAvailable - peopleInLine[i] + 25;
                }
            }

            return "YES";
        }
    }
}
