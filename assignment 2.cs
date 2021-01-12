using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userNumbers = new int[10];
            int counter = 0;

            Console.WriteLine("Please enter 10 numbers.");
            
            for (counter = 0; counter < 10; counter++)
            {
                userNumbers[counter] = Convert.ToInt32(Console.ReadLine());
            }    
            

            Console.WriteLine("The largest number was:\n");
            
            Array.Sort(userNumbers);
            Console.WriteLine(userNumbers[9]);
                     
            
           
            Console.ReadLine();
        }
    }
}
