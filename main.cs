using System;

namespace Csharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi!  What's your name?  ");
            string name = Console.ReadLine();
            Console.Write("Hi, " + name + "!  How ya doin'?  ");
            string status = Console.ReadLine();
            Console.Write(status + "?  Why " + status.ToLower() + "?  ");
            string reason = Console.ReadLine();
            Console.Write("Oh, okay.  Well...wanna party with me?  ");
            string answer = Console.ReadLine();
            
            if (answer.ToLower().Contains("yes") || answer.ToLower().Contains("yeah"))
            {
                Console.WriteLine("Cool!  Let's hit it!");
            } else
            {
                Console.WriteLine("Aww, you're lame!  LAAAAAAME!!!");
            }
            
            Console.ReadLine();
        }
    }
}
