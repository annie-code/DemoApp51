using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to git");
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter location");
            string loc = Console.ReadLine();
            Console.WriteLine($"{name}    {loc}");
            Console.Read();
        }
    }
}
