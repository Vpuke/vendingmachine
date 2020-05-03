using System;



namespace VendingMachineAssignment
{
    public class Menu
    {
        public void MainMenu()
        {
            
        var vendingMachine = new VendingMachine();
        
            while (true)
        {
            Console.WriteLine();
            Console.WriteLine("********   Virtual Vending Machine   ********");
            Console.WriteLine("*********************************************");
            Console.WriteLine("        Press 1 for Vending Machine");
            Console.WriteLine("        Press 2 to deposit money");
            Console.WriteLine("        Press 3 for your balance");
            Console.WriteLine("        Press 4 for your purchase history ");
            var stringMenu = Console.ReadLine();
            var nextChoice = Convert.ToInt32(stringMenu);

            switch (nextChoice)
            {
                case 1:
                    vendingMachine.DisplayMachine();
                    break;
                case 2:
                    Program.Bank.Deposit();
                    break;
                case 3:
                    Program.Bank.Balance();
                    break;
                case 4:
                    Program.Inventory.Display();
                    break;
                } 
            } 
        }
    }
}