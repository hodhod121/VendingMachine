using System;

namespace VM
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine=new();
            vendingMachine.DisplayCoinSelection();
            vendingMachine.DisplayProductSelections();
        }
    }
}
