using System;
using VendingMachine;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {            
          VendingMachine vendingMachine=new();
            //vendingMachine.DisplayCoinSelection();
            //vendingMachine.DisplayProductSelections();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine(" 0) Exit");
            Console.WriteLine(" 1) Product list");            
            Console.WriteLine(" 2) Purchase");                            
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "0":
                    return false;
                case "1":
                    ShowAll();
                    return true;               
                case "2":
                    Purchase();
                    return true;
                default:
                    return true;
            }
        }
        private static string ShowAll()
        {
            Console.Clear();            
            VendingMachine vendingMachine = new();
            vendingMachine.ShowAll();
            Console.Write("\r\nPress Enter to return to Main Menu");

            return Console.ReadLine();
        }
       
        private static string Purchase()
        {
            Console.Clear();
            VendingMachine vendingMachine = new();
            vendingMachine.Purchase();
            Console.Write("\r\nPress Enter to return to Main Menu");

            return Console.ReadLine();
        }
    }
}

