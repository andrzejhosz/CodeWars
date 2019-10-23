using System;

namespace WhoLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Likes(new string[] { "Jacob", "Alex" }));
            Console.ReadKey();
        }

        public static string Likes(string [] name)
        {
           if (name.Length == 1)
            {
                return $"{name[0]} likes this";
            }
           if(name.Length == 2)
            {
                return $"{name[0]} and {name[1]} like this";
            }
           if (name.Length == 3)
            {
                return $"{name[0]}, {name[1]} and {name[2]} like this";
            }
           if(name.Length>3)
            {
                return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
            else
            {
                return "no one likes it";
            }
           
        }
    }
}
