using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM
{
    class VendingMachine:IVending
    {
        const int COST_OF_CANDY = 32;
        const int COST_OF_CHIPS = 43;
        const int COST_OF_COFFEE = 32;
        const int COST_OF_COLD_FOOD = 320;
        const int COST_OF_COOKIES = 41;
        const int COST_OF_FRESH_FRUIT = 29;
        const int COST_OF_MILK = 35;
        public int TOTAL_COST = 0;
        public int Price = 0;
        public int TotalPrice { get; set; }
        void ChooseProduct(char item)
        {
            if (item == '1')
            {
                TOTAL_COST += COST_OF_CANDY;
            }
            else if (item == '2')
            {
                TOTAL_COST += COST_OF_CHIPS;
            }
            else if (item == '3')
            {
                TOTAL_COST += COST_OF_COFFEE;
            }
            else if (item == '4')
            {
                TOTAL_COST += COST_OF_COLD_FOOD;
            }
            else if (item == '5')
            {
                TOTAL_COST += COST_OF_COOKIES;
            }
            else if (item == '6')
            {
                TOTAL_COST += COST_OF_FRESH_FRUIT;
            }
            else
            {
                TOTAL_COST += COST_OF_MILK;
            }
        }
        public void InsertMoney()
        {           
            Console.WriteLine();
            Console.WriteLine("Enter a valid coin!");
            Console.WriteLine("1 - 1kr , 5 - 5kr , 10 - 10kr , 20 - 20kr , 50 - 50kr");
            Console.WriteLine("100 - 100kr , 500 - 500kr , 1000 - 1000kr");
            bool ChooseMore = true;           
            int[] myArr = { 1, 5, 10, 20, 50, 100, 500, 1000 };
            IList<int> items = Array.AsReadOnly(myArr);
            while (ChooseMore)
            {
                int output;
                string input_1 = Console.ReadLine();
                while (!int.TryParse(input_1,out output))
                {
                    Console.WriteLine("You need to enter valid integer number!");
                    input_1 = Console.ReadLine();
                }
                if (items.Contains(int.Parse(output.ToString())))
                {
                    CoinDenomination(output);
                }
                else
                {
                    Console.WriteLine($"{output} is not valid amount!");
                    Console.WriteLine("Please choose valid amount");
                }
                Console.WriteLine("Enter Y or YES if you want select more money?");
                string answer = Console.ReadLine();
                if (!(answer.ToUpper() == "Y" || answer.ToUpper() == "YES"))
                {
                    ChooseMore = false;
                }
            }
            Console.WriteLine(TotalPrice);          
        }
      
        public void CoinDenomination(int coin)
        {
            switch (coin)
            {
                case (1):
                    TotalPrice += 1;
                    break;
                case (5):
                    TotalPrice += 5;
                    break;
                case (10):
                    TotalPrice += 10;
                    break;
                case (20):
                    TotalPrice += 20;
                    break;
                case (50):
                    TotalPrice += 50;
                    break;
                case (100):
                    TotalPrice += 100;
                    break;
                case (500):
                    TotalPrice += 500;
                    break;
                case (1000):
                    TotalPrice += 1000;
                    break;
                default:
                    Console.WriteLine("Invalid amount");
                    break;
            }
        }
        public void Purchase()
        {
            ShowAll();
            InsertMoney();
            Console.WriteLine();           
            Console.WriteLine("1 - Candy , 2 - Chips , 3 - Coffee , 4 - Milk");
            Console.WriteLine("5 - Cold Food , 6 - Cookies , 7 - Fresh Fruit");
            Console.WriteLine("Choose your product number like this: 6");
            bool ChooseMore = true;            
            string[] items = new string[] {"1","2","3","4","5","6","7" };

            while (ChooseMore)
            {
                string input_1 = Console.ReadLine();               
                if (items.Contains(input_1)) { 
                    char item = Convert.ToChar(input_1);
                    ChooseProduct(item);
                    if (TOTAL_COST < TotalPrice)
                    {

                        Console.WriteLine("Enter Y or YES if you want more?");
                        string answer = Console.ReadLine();
                        if (!(answer.ToUpper() == "Y" || answer.ToUpper() == "YES"))
                        {
                            ChooseMore = false;
                            EndTransaction();
                        }                     
                    }
                    if (TOTAL_COST == TotalPrice)
                    {
                        ChooseMore = false;
                        EndTransaction();
                    }
                    if (TOTAL_COST > TotalPrice)
                    {
                        Console.WriteLine("Your total cost was more than total price, please try again!");
                        ChooseMore = false;
                    }
                }
                else
                {
                    Console.WriteLine("You need to enter valid integer number between 1 and 7!");                    
                }
            }
        }
        public void EndTransaction()
        {
            if (TotalPrice-TOTAL_COST >= 0)
            {
                Console.WriteLine("Thank you for choising our producs");
                ReturnChange();
            }
            else
            {
                Console.WriteLine("Your total cost was more than total price, please try again!");
            }
        }
        void ReturnChange()
        {
            Console.WriteLine($"Your change is {TotalPrice-TOTAL_COST} kr");
        }
        public void ShowAll()
        {
            Console.WriteLine("This is the list of our products");
            Console.WriteLine("1 Candy");
            Console.WriteLine("2 Chips");
            Console.WriteLine("3 Coffee");
            Console.WriteLine("4 Cold food");
            Console.WriteLine("5 Cookies");
            Console.WriteLine("6 Fresh fruit");
            Console.WriteLine("7 Milk");
        }
    }
}

