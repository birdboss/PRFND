using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_9_2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool running = true;
            bool mod = false;
            List<Student> studentList = Student.getList();

            displayMenu(running, mod, studentList);

        }

        private static void displayMenu(bool isRunning, bool mod, List<Student> studentList)
        {
            string selection = "0";
            while (isRunning == true)

            {
                Console.WriteLine("Please select one of the following options by entering its corresponding number. \n 1 - Add a new student \n 2 - Display a student \n 3 - Modify a student \n 4 - Display all students \n 5 - Quit");
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        mod = Student.addStudent(mod, studentList);

                        break;
                    case "2":
                        Student.displayStudent(studentList, mod);

                        break;
                    case "3":
                        mod = true;
                        Student.inputStudent(studentList, mod);

                        break;
                    case "4":
                        Student.displayAll(studentList);

                        break;
                    case "5":
                        isRunning = false;
                        Console.WriteLine("Exiting program, press Enter to close.");
                        Console.ReadLine();
                        break;
                    default:
                        isRunning = true;
                        break;
                }
            }

        }


    }
}
