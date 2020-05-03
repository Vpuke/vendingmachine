using System;

namespace VendingMachineAssignment
{
    class Program
    {
      public static Bank Bank = new Bank();
      public static Inventory Inventory = new Inventory();
        
        static void Main(string[] args)
        {
            
            var menu = new Menu();
            menu.MainMenu();

        }
    }
}