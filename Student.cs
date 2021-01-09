﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_9_2
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        private string _ID;
        private string _grade;
        

        public Student(string fname, string lname, string id, string grade)
        {
            _firstName = fname;
            _lastName = lname;
            _ID = id;
            _grade = grade;
        }

        public static List<Student> getList()
        {
            List<Student> aList = new List<Student>();

            return aList;
        }

        public string ID { get => _ID; set => _ID = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string Grade { get => _grade; set => _grade = value; }

        public static void displayAll(List<Student> studentList)
        {
            foreach (Student i in studentList)
            {
                Console.WriteLine(i.FirstName);
                Console.WriteLine(i.LastName);
                Console.WriteLine(i.ID);
                Console.WriteLine(i.Grade);
            }

            
        }

        internal static bool modStudent(List<Student> studentList)
        {
            bool mod = true;
           
            inputStudent(studentList, mod);
            //    while (mod == true)
            //    { 
            //    string id = searchStudent(studentList, mod);
            //    Console.WriteLine("Please select one of the following options by entering its corresponding number. \n 1 - Update name \n 2 - Update student ID \n 3 - Update grade\n 4 - Quit");
            //    string selection = Console.ReadLine();


            //        switch (selection)
            //        {
            //            case "1":
            //                Console.Write("Enter the student's updated...\nFirst name: ");


            //                break;
            //            case "2":
            //                Console.Write("Enter the student's new...\nID number:");
            //                string _id = Console.ReadLine();
            //                _id = validateID(studentList, _id);


            //                break;

            //            case "3":
            //                Console.Write("Enter the student's udated...\nGade: ");
            //                int num = Convert.ToInt32(Console.ReadLine());
            //                string grade = getGrade(num, mod, studentList);
            //                break;

            //            default:
            //                mod = false;
            //                break;
            //        }
            //    }
            return mod;
        }

        internal static void displayStudent(List<Student> studentList, bool mod)
        {
            string id = searchStudent(studentList, mod);
            foreach (Student i in studentList)
            {
                if (id == i.ID)
                {                    
                    Console.WriteLine(i.FirstName);
                    Console.WriteLine(i.LastName);
                    Console.WriteLine(i.ID);
                    Console.WriteLine(i.Grade);
                    Console.ReadLine();
                }
            }
        }

        public static string searchStudent(List<Student> studentList, bool mod)
        {
            Console.Write("Please enter the student's ID: ");
            string id = Console.ReadLine();
            bool add = false;
            validateID(studentList, id, add);

            if (mod == true)
            {
                for (int i = 0; i < studentList.Count; i++)
                {
                    if (studentList[i].ID.Equals(id))
                    {

                        
                        return id;
                    }
                }
            }
            else
            {
                for (int i = 0; i < studentList.Count; i++)
                {
                    if (studentList[i].ID.Equals(id))
                    {

                        return id;
                    }
                }
            }
            return id;
            
        }

        internal static bool addStudent(bool aMod, List<Student> studentList)
        {
            aMod = false;            
            inputStudent(studentList, aMod);
            return aMod;
                     
            
        }

        public static void inputStudent(List<Student> studentList, bool aMod)
        {

            string fname;
            string lname;
            string id;
            string grade;

            if (aMod != true)
            {

                bool add = true;

                Console.Write("Please enter the student's first name: ");
                fname = Console.ReadLine();

                Console.Write("Please enter the student's last name: ");
                lname = Console.ReadLine();

                Console.Write("Please input the student's ID number: ");
                id = Console.ReadLine();
                id = validateID(studentList, id, add);

                Console.Write("Please enter a grade amount between 0 and 100: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
                grade = getGrade(num, aMod, studentList);

                studentList.Add(new Student(fname, lname, id, grade));


            }

            if (aMod == true)
            {
                bool add = false;

                int i = Convert.ToInt32(searchStudent(studentList, aMod));
                
                Console.Write("Please enter the student's first name: ");
                fname = Console.ReadLine();

                Console.Write("Please enter the student's last name: ");
                lname = Console.ReadLine();

                Console.Write("Please input the student's ID number: ");
                id = Console.ReadLine();
                id = validateID(studentList, id, add);

                Console.Write("Please enter a grade amount between 0 and 100: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
                grade = getGrade(num, aMod, studentList);
                
                //NOTE: THERE IS A PROBLEM HERE BECAUSE I'M STRUGGLING TO FIGURE OUT HOW TO BRING OVER THE INDEX NUMBER
                studentList[i].FirstName = fname;
                studentList[i].LastName = lname;
                studentList[i].ID = id;
                studentList[i].Grade = grade;
            }
        }

        public static string validateID(List<Student> studentList, string id, bool add)
        {
            if (add == true)
            {
                foreach (Student i in studentList)
                {
                    while (i.ID == id || id.Length > 3 || !id.All(char.IsDigit))
                    {

                        Console.WriteLine("Error invalid ID: Please enter the student's unique, three digit ID number.");
                        id = Console.ReadLine();
                    }
                }
            }
            else
            {
                foreach (Student i in studentList)
                {
                    while (id.Length > 3 || !id.All(char.IsDigit))
                    {

                        Console.WriteLine("Error invalid ID: Please enter the student's unique, three digit ID number.");
                        id = Console.ReadLine();
                    }
                }
            }
                return id;
            
        }

        public static string getGrade(int num, bool aMod, List<Student> studentList)
        {
            string aGrade;
            gradeCheck(num, aMod, studentList);

            if (num <= 100 && num >= 90)
            {
                aGrade = "A";
                return aGrade;
            }
            else if (num <= 90 && num >= 80)
            {
                aGrade = "B";
                return aGrade;
            }
            else if (num <= 80 && num >= 70)
            {
                aGrade = "C";
                return aGrade;

            }
            else if (num <= 70 && num > 60)
            {
                aGrade = "D";
                return aGrade;

            }
            else
            {
                aGrade = "Fail";
                return aGrade;


            }
        }

        internal static void gradeCheck(int num, bool aMod, List<Student> studentList)
        {
            
            while (num > 100 || num < 0)
            {
                Console.WriteLine("The grade must be a whole number between 0 and 100.\nPlease reenter the student's correct information.");
                Console.ReadLine();
                inputStudent(studentList, aMod);
            }
        }
    }
}
