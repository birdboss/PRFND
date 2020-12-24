using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            string inpFirstName;
            string inpLastName;
            string inpNumber;
            int menuInput = 0;
            int newAdd = 0;

            string[,] studentData = new string [20,3];
            


            Console.WriteLine("What would you like to do? Please complete one of the following actions: \n To input a new student enter: 1 \n To search for a student enter: 2 \n To display all students enter: 3");
            menuInput = Convert.ToInt32(Console.ReadLine());

            while (menuInput > 0)
            {
                inputMenu();
              
            }

            void inputMenu()
            {
                if (menuInput==1)
                {
                    newStudent();
                }
                else if (menuInput==2)
                {
                    getStudent();
                }
                else if (menuInput==3)
                {
                    displayStudents();
                }
                menuInput = 0;
                Console.WriteLine("What would you like to do? Please complete one of the following actions: \n To input a new student enter: 1 \n To search for a student enter: 2 \n To display all students enter: 3");
                menuInput = Convert.ToInt32(Console.ReadLine());
                return;
            }
            void newStudent()
            {
                if (newAdd < 19)
                {
                    Console.WriteLine("Enter first Name.");
                    inpFirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name.");
                    inpLastName = Console.ReadLine();
                    Console.WriteLine("Enter student number.");
                    inpNumber = Console.ReadLine();
                    studentData[newAdd, 0] = inpFirstName;
                    studentData[newAdd, 1] = inpLastName;
                    studentData[newAdd, 2] = inpNumber;
                    newAdd++;                                                                      
                }
                else
                {
                    Console.WriteLine("Database is full.");
                    Console.ReadLine();
                }
                
                return;
                
            }
            void displayStudents()
            {
                Console.WriteLine("displaying all students.");
                int i = 0;
                for (i = 0; i < 20; i++)
                {
                    Console.WriteLine(studentData[i,0]);
                    Console.WriteLine(studentData[i,1]);
                    Console.WriteLine(studentData[i,2]);

                }
                Console.ReadLine();
            }

             void getStudent()
            {
                string userInput;
                Console.Write("Enter student number:");
                userInput = Console.ReadLine();
                bool found = false;
                for (int i = 0; i < 3; i++)
                {
                    if (studentData[i,2] == userInput)
                    {
                        found = true;
                        Console.WriteLine("Student name: " + studentData[i, 0] + studentData[i, 1]);
                        Console.WriteLine("Student number: " + studentData[i, 2]);
                        Console.ReadLine();

                    }
                    if (!found)
                    {
                        Console.WriteLine("Student data not found.");
                    }
                }
                
                
            }
        }

        
    }

      
    }

