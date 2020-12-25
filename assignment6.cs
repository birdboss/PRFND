using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    class Program
    {
        static void Main(string[] args)
        {      
          
                 
                    

            Console.Write("Please enter the PST value with decimal: ");
            double PST = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the GST value with decimal: ");
            double GST = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the cost of the item with decimal: ");
            double cost = Convert.ToDouble(Console.ReadLine());
            double tax = GST + PST;
            displayTax(PST, cost);          
            displayTax(GST, cost);
            double total = getTotal(cost, tax);            
            displayTotal(total);

            
            void displayTax(double aTax, double aCost)
            {
                if (aTax == GST)
                {
                    Console.WriteLine("The total GST charge is: " + Convert.ToString(aTax * aCost));
                    
                }

                else if (aTax == PST)
                {
                    Console.WriteLine("The total PST charge is: " + Convert.ToString(aTax * aCost));
                    
                }

            }
            double getTotal(double aCost, double aTax)
            {
                
                return aCost * aTax + aCost;
            }

            void displayTotal(double aTotal)
            {
                Console.WriteLine("The total cost with tax is: " + Convert.ToString(aTotal));
                Console.ReadLine();
            }


        }

       
    }
    
}
