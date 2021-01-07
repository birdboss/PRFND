using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assignment_9
{
    class Program
    {






        static void Main(string[] args)
        {
            int counter = 0;
            string grade;
            int selection = 0;

            List<Student> listStudents = new List<Student>();

            






            void displayMenu()
            {
                while selection = 0
                {
                    Console.WriteLine("Please select one of the following options by entering its corresponding number. \n 1 - Add a new student \n 2 - Display a student \n 3 - Modify a student \n 4 - Display all students \n 5 - Quit");
                    selection = convert.ToInt32(Console.ReadLine());
                    
                }
                //changing to switch cases
                if (selection == 1)
                {
                    addStudent();
                    selection = 0
                }
                if (selection == 2)
                {
                    displayInfo();
                    selection = 0
                }
                
            }
            
            void addStudent()
            {
                
                displayMenu();
                
                
                listStudents.Add(new Student());
                inputName();
                inputId();
                inputGrade();
                
                displayInfo();

                counter++;
                
            }
            void displayInfo()
            {
                Console.WriteLine("The student's information is as follows...");
                Console.WriteLine("Name: " + listStudents[counter].FirstName + " " + listStudents[counter].LastName);
                Console.WriteLine("ID: " + listStudents[counter].Id);
                Console.WriteLine("Grade: " + listStudents[counter].Grade);
            }

            void inputId()
            {
                Console.Write("Please input the student's ID number: ");
                listStudents[counter].Id = Console.ReadLine();

            }
            void inputName()
            {
                Console.Write("Please enter the student's first name: ");
                listStudents[counter].FirstName = Console.ReadLine();

                Console.Write("Please enter the student's last name: ");
                listStudents[counter].LastName = Console.ReadLine();


            }

            void inputGrade()
            {
                
                Console.Write("Please enter a grade amount between 0 and 100: ");
                int num = Convert.ToInt32(Console.ReadLine());
                grade = getGrade(num);                
                listStudents[counter].Grade = grade;
            }


            
            void gradeCheck(int num)
            {
                while (num > 100 || num < 0)
                {
                    Console.WriteLine("Please enter a value between 0 and 100.");
                    Console.ReadLine();
                    inputGrade();

                }



            }

            string getGrade(int num)
            {

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


        }
    }
}
