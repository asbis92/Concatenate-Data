using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingsByName
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine(data(firstName, lastName, age, town));

        }
        static string data (string fN, string lN, double age, string town)
        {
            string fullData = ("You are " + fN + " " + lN + ", a " + age +  "-years old person from " + town + ".");
            return fullData;
        }
    }
}
