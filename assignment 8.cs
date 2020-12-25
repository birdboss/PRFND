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

            displayMenu();

            



        }

        private static void displayMenu()
        {
            Console.WriteLine("Please select one of the following options \n Enter student name = 1 \n Enter student grade = 2 \n Display student grade = 3 \n Exit = 4");
            int num = Convert.ToInt32(Console.ReadLine());
            menuChoice(num);
        }

        private static void menuChoice(int num)
        {
            if (num == 1)
            {
                getName();
                displayMenu();
            }
            else if (num == 2)
            {
                getNum();
                displayMenu();
            }
            else if (num == 3)
            {
                getAll();
            }
            else if (num == 4)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
                Console.ReadLine();
                displayMenu();
            }
        }

        private static void getAll()
        {
            string name = getName();             
            string grade = getNum();
            Console.ReadLine();
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Student grade: " + grade);
            Console.ReadLine();
            displayMenu();

            
        }

        private static string getNum()
        {
           
            {
                Console.Write("Please enter your grade as a value between 0 and 100: ");
                int num = Convert.ToInt32(Console.ReadLine());
                string grade = getGrade(num);
                return grade;
            }
            
            
        }

        private static string getName()
        {
            Console.Write("Please enter the student's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("The student's name is: " + name);
            Console.ReadLine();
            return name;
        }

     

        private static void gradeCheck(int num)
        {
            while (num > 100 || num < 0)
            {
                Console.WriteLine("Please enter a value between 0 and 100.");
                Console.ReadLine();
                getNum();
                               
            }

            

        }

        private static string getGrade(int num)
        {
            string grade;
            gradeCheck(num);

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
        private static string displayGrade(string grade)
        {
            Console.WriteLine("Your current mark is: " + grade);
            Console.ReadLine();
            return grade;
        }
    }
}
