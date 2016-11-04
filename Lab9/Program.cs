using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            string answer;
            int count = 0;
            do
            {
                var open = CircleApp.checkRadius();
                CircleApp.printAnswers(open);

                Console.Write("Continue? (y/n): ");
                answer = Console.ReadLine() + Environment.NewLine;
                count++;
            }
            while (answer.ToLower() == "y" || answer.ToLower() == "yes");
            Console.WriteLine("Goodbye. You created {0} Circle object(s).", count);
        }
    }
}
