using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Client
    {
        private string _firstName;
        private string _lastName;
        private string _ID;
        private double _total;


        public Client(string fname, string lname, string id, double total)
        {
            _firstName = fname;
            _lastName = lname;
            _ID = id;
            _total = total;
        }
        public static List<Client> getList()
        {
            List<Client> aList = new List<Client>();

            return aList;
        }

        public string ID { get => _ID; set => _ID = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public double Total { get => _total; set => _total = value; }

        public static void addClient(List<Client> clientList)
        {
            Console.Write("Please enter the client's first name: ");
            string fname = Console.ReadLine();

            Console.Write("Please enter the client's last name: ");
            string lname = Console.ReadLine();

            Console.Write("Please input the client's ID number: ");
            string id = Console.ReadLine();
            id = validateID(clientList, id);

            Console.Write("Please enter the dollar amount with decimal (e.g., 10.45): $");
            string _total = Console.ReadLine();
            double total = Convert.ToDouble(validateTotal(clientList, _total));
            

            Console.ReadLine();

            clientList.Add(new Client(fname, lname, id, total));
        }

        //NOTE : NOT SURE HOW TO MAKE SURE THE STRING IS ABLE TO CONTAIN BOTH DECIMAL AND NUMERIC VALUES. TRIED "CONTAINS" AND "ALL" BUT NOT SURE HOW TO MAKE THEM WORK WITH THIS.
        private static string validateTotal(List<Client> clientList, string total)
        {
            while (total.(char.IsLetter))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error invalid ID: Please ensure the client's unique, three digit ID number and re-enter the data as prompted.");
                Console.ForegroundColor = ConsoleColor.White;
                total = Console.ReadLine();
                addClient(clientList);
            }

            return total;
        }

        public static void displayClient(List<Client> clientList)
        {
            string id = searchClient(clientList);
            foreach (Client i in clientList)
            {
                if (id == i.ID)
                {
                    Console.WriteLine("\nName: " + i.FirstName +" "+ i.LastName);                    
                    Console.WriteLine("ID number: " + i.ID);
                    Console.WriteLine("Total: $" + i.Total);
                    Console.ReadLine();
                }
            }

        }

        private static string validateID(List<Client> clientList, string id)
        {            
            foreach (Client i in clientList)
            {
                while ( id.Length > 3 || !id.All(char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error invalid ID: Please enter the client's unique, three digit ID number.");
                    id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return id;
        }

        

        private static string searchClient(List<Client> clientList)
        {
            Console.Write("Please enter the client's ID number: ");
            string id = Console.ReadLine();            
            validateID(clientList, id);
            
            
                for (int i = 0; i < clientList.Count; i++)
                {
                    if (clientList[i].ID.Equals(id))
                    {


                        return id;
                    }
                }
            return id;
        }

        public static void displayAll(List<Client> clientList)
        {
            foreach (Client i in clientList)
            {
                Console.WriteLine("\nName: " + i.FirstName +" "+ i.LastName);
                Console.WriteLine("ID number: " + i.ID);
                Console.WriteLine("Total: $" + i.Total + "\n");
                
            }
            Console.ReadLine();
        }
    }
}
