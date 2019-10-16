using System;
using System.Linq;

namespace SortingInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę:");
            string num = (Console.ReadLine());
            if (num.Length > 9)
            {
                Console.WriteLine("Podałeś zbyt dużą liczbę");
                Console.WriteLine("Podaj liczbę:");
                num = (Console.ReadLine());
            }
            Console.WriteLine("Wybierz sortowanie :");
            Console.WriteLine("1 - rosnące");
            Console.WriteLine("2 - malejące");
            var sel = Console.ReadLine();
            switch (sel)
            {
                case "1": ;
                    int wynikdesc = AscendingOrder(int.Parse(num));
                    Console.WriteLine(wynikdesc);
                    break;
                case "2": ;
                    int wynikasc = DescendingOrder(int.Parse(num));
                    Console.WriteLine(wynikasc);
                    break;
            }
            Console.ReadKey();
        }            

        public static int DescendingOrder(int num)
        {
            var orderlist = num.ToString().OrderByDescending(n => n);
            return int.Parse(String.Concat(orderlist));
        }

        public static int AscendingOrder(int num)
        {
            var orderlist = num.ToString().OrderBy(n => n);
            return int.Parse(String.Concat(orderlist));
        }
    }
}
