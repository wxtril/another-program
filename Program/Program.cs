using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vladhoes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, here you can create your list of the best porn acters about your opinion.");
            Console.WriteLine("Please, write your name.");
            String name;
            string[] u;
            u = new string[5];
            name = Console.ReadLine();
            Console.WriteLine(name + " ,We have pleasure see you here.");
            Console.WriteLine("Please write the name of porn acter");
            string a = Console.ReadLine();
            //1
            u[0] = a;
            Console.WriteLine("You wrote the name is " + u[0]);
            Console.WriteLine("Write the next 5 names");
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            string f = Console.ReadLine();
            string e = Console.ReadLine();
            u[1] = b;
            u[2] = c;
            u[3] = d;
            u[4] = f;
            for (int i = 0; i < u.Length; i++)
            {
                Console.WriteLine(u[i]);
                continue;
            }
            Console.WriteLine("Thanks for your informations it's help us to do this list more popular.");

        }
    }
}


