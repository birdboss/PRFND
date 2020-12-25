using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int num = displayPrompt();
            gradeCheck(num);
            string grade = getGrade(num);
            displayGrade(grade);



        }

        

        private static int displayPrompt()
        {
            Console.Write("Please enter your grade as a value between 0 and 100: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
            
        }

        private static void gradeCheck(int num)
        {
            while (num > 100 || num < 0)
            {
                Console.WriteLine("Please enter a value between 0 and 100.");
                Console.ReadLine();
                displayPrompt();
                               
            }

            return;       
            
        }

        private static string getGrade(int num)
        {
            string grade;
            
            if (num == 100 && num > 90)
            {
                grade = "A";
                return grade;
            }
            else if (num < 90 && num > 80)
            {
                grade = "B";
                return grade;
            }
            else if (num < 80 && num > 70)
            {
                grade = "C";
                return grade;

            }
            else if (num < 70 && num > 60)
            {
                grade = "D";
                return grade;

            }
            else
            {
                grade = "Fail";
                return grade;

            }

            


        }
        private static void displayGrade(string grade)
        {
            Console.WriteLine("Your current mark is: " + grade);
            Console.ReadLine();
        }
    }
}
