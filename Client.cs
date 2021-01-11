using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            List<Client> clientList = Client.getList();

            displayMenu(running, clientList);
        }


        private static void displayMenu(bool isRunning, List<Client> clientList)
        {
            string selection = "0";
            while (isRunning == true)

            {
                Console.WriteLine(" 1 - Add a new Client \n 2 - Display a Client \n 3 - Display all Clients \n 4 - Quit\nPlease select one of the following options by entering its corresponding number.");
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Client.addClient(clientList);

                        break;
                    case "2":
                        Client.displayClient(clientList);

                        break;
                    case "3":
                        Client.displayAll(clientList);

                        break;
                    case "4":
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
