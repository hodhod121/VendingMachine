using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using VM.Products;

namespace VendingMachine
{
    public class VendingMachine:IVending
    {
        Candy candy = new("polkagris", "100g");
        Candy candy_gummi = new("gummibjörn", "10g");
        Candy candy_kola = new("kola", "50g");
        Chips chips = new("chips", "70g");
        Chips chips_dill = new("dillchips", "70g");
        Chips chips_onion = new("onionchips", "70g");
        Coffee coffee_milk = new("coffe by milk", "100g");
        Coffee coffee_chocolate = new("chocolate coffee", "100g");
        Coffee coffee = new("coffee", "100g");
        ColdFood coldFood = new("cold food", "100g");
        ColdFood coldFood_shrimps = new("shrimp sallad", "100g");
        ColdFood coldFood_egg= new("egg sallad", "100g");
        Cookies cookies = new("cookies", "90g");        
        FreshFruit freshFruit = new("fruits", "190g");
        FreshFruit freshFruit_banana = new("banana", "190g");
        FreshFruit freshFruit_mix = new("mix fruits", "190g");
        Milk milk = new("milk", "100g");       
        public int TOTAL_COST = 0;
        public int Price = 0;
        public int TotalPrice { get; set; }
        List<string> list = new List<string>();
        void ChooseProduct(char item)
        {
            if (item == 'a')
            {
                TOTAL_COST += candy.price();
                list.Add(candy.Use());
            }
            if (item == 'b')
            {
                TOTAL_COST += candy_gummi.price();
                list.Add(candy_gummi.Use());
            }
            if (item == 'c')
            {
                TOTAL_COST += candy_kola.price();
                list.Add(candy_kola.Use());
            }
            else if (item == 'd')
            {
                TOTAL_COST += chips_dill.price();
                list.Add(chips.Use());
            }
            else if (item == 'e')
            {
                TOTAL_COST += chips.price();
                list.Add(chips_onion.Use());
            }
            else if (item == 'f')
            {
                TOTAL_COST += chips.price();
                list.Add(chips.Use());
            }
            else if (item == 'g')
            {
                TOTAL_COST += coffee.price();
                list.Add(coffee.Use());
            }
            else if (item == 'h')
            {
                TOTAL_COST += coffee.price();
                list.Add(coffee_milk.Use());
            }
            else if (item == 'i')
            {
                TOTAL_COST += coffee.price();
                list.Add(coffee_chocolate.Use());
            }
            else if (item == 'j')
            {
                TOTAL_COST += coldFood.price();
                list.Add(coldFood.Use());
            }
            else if (item == 'k')
            {
                TOTAL_COST += coldFood.price();
                list.Add(coldFood_shrimps.Use());
            }
            else if (item == 'l')
            {
                TOTAL_COST += coldFood.price();
                list.Add(coldFood_egg.Use());
            }
            else if (item == 'm')
            {
                TOTAL_COST += cookies.price();
                list.Add(cookies.Use());
            }
            else if (item == 'n')
            {
                TOTAL_COST += freshFruit.price();
                list.Add(freshFruit.Use());
            }
            else if (item == 'o')
            {
                TOTAL_COST += freshFruit.price();
                list.Add(freshFruit_banana.Use());
            }
            else if (item == 'p')
            {
                TOTAL_COST += freshFruit.price();
                list.Add(freshFruit_mix.Use());
            }
            else if(item=='q')
            {
                TOTAL_COST += milk.price();
                list.Add(milk.Use());
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
            Console.WriteLine("a - Candy , b - gummi candy, c - kola candy , d - Chips , e - chips by dill");
            Console.WriteLine("f - chips by onion , g - coffee, h - coffee by chocolate , i - coffee by milk");
            Console.WriteLine("j - Cold Food , k - shrimp sallad , l - egg sallad , m - Cookies ");
            Console.WriteLine("n - fresh fruits , o - bananas , p - mix fruits , q - milk");
            Console.WriteLine("Choose your product letter like this: b");
            bool ChooseMore = true;            
            string[] items = new string[] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q" };

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
                Console.Clear();
                Console.WriteLine("Thank you for choising our producs");
                List<string> distinct = list.Distinct().ToList();
                foreach (string item in distinct)
                {
                    Console.WriteLine(item);
                }
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
            candy.Examine();
            candy_gummi.Examine();
            candy_kola.Examine();
            chips.Examine();
            chips_dill.Examine();
            chips_onion.Examine();
            coffee.Examine();
            coffee_chocolate.Examine();
            coffee_milk.Examine();
            coldFood.Examine();
            coldFood_shrimps.Examine();
            coldFood_egg.Examine();
            cookies.Examine();
            freshFruit.Examine();
            freshFruit_banana.Examine();
            freshFruit_mix.Examine();
            milk.Examine();        
        }
    }
}

