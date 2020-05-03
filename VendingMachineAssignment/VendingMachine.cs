using System;



namespace VendingMachineAssignment
{
    public class VendingMachine : GoodsItem
    { 
        Items cola = new Items("Coca-Cola", 1.5, 10 );
        Items fanta = new Items("Fanta", 1.5, 6);
        Items redbull = new Items("Redbull", 3, 9);
        Items gatorade = new Items("Gatorade", 2.5, 10);
        Items sprite = new Items("Sprite", 1.5, 11);
        Items dietCoke = new Items("Diet-Coke", 1.5, 12);
        
        public void DisplayMachine()
        { 
            
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("Selection     -     Product     -       Price     -    Stock ");
            Console.WriteLine($"    A              {cola.Product}            {cola.Price}            {cola.Quantity}");
            Console.WriteLine($"    B              {fanta.Product}                {fanta.Price}            {fanta.Quantity}");
            Console.WriteLine($"    C              {redbull.Product}              {redbull.Price}              {redbull.Quantity}");
            Console.WriteLine($"    D              {gatorade.Product}             {gatorade.Price}            {gatorade.Quantity}");
            Console.WriteLine($"    E              {sprite.Product}               {sprite.Price}            {sprite.Quantity}");
            Console.WriteLine($"    F              {dietCoke.Product}            {dietCoke.Price}            {dietCoke.Quantity}");
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("Please make a selection of beverage");
            ItemSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
        }

        private void ItemSelection(char selection)
        {
            
            var validSelection = false;
            while (!validSelection)
            {
                double price;

                try
                {
                    switch (selection)
                    {
                        case 'A':
                            price = 1.5;
                            validSelection = true;
                            Program.Bank.Withdrawal(price);
                            Program.Inventory.Products("Coca-cola");
                            cola.Quantity = cola.Quantity - 1;
                            Console.WriteLine($"Thank you for purchasing a Coca-Cola , your total is ${price}");
                            break;
                        case 'B':
                            price = 1.5;
                            validSelection = true;
                            Program.Bank.Withdrawal(price);
                            Program.Inventory.Products("Fanta");
                            fanta.Quantity = fanta.Quantity - 1; 
                            Console.WriteLine($"Thank you for purchasing a Fanta, your total is ${price}");
                            break;
                        case 'C':
                            price = 3;
                            validSelection = true;
                            Program.Bank.Withdrawal(price);
                            Program.Inventory.Products("Redbull");
                            redbull.Quantity = redbull.Quantity - 1;
                            Console.WriteLine($"Thank you for purchasing a Redbull, your total is ${price}");
                            break;
                        case 'D':
                            price = 2.5;
                            validSelection = true;
                            Program.Bank.Withdrawal(price);
                            Program.Inventory.Products("Gatorade");
                            gatorade.Quantity = gatorade.Quantity - 1;
                            Console.WriteLine($"Thank you for purchasing a Gatorade, your total is ${price}");
                            break;
                        case 'E':
                            price = 1.5;
                            validSelection = true;
                            Program.Bank.Withdrawal(price);
                            Program.Inventory.Products("Sprite");
                            sprite.Quantity = sprite.Quantity - 1;
                            Console.WriteLine($"Thank you for purchasing a Sprite, your total is ${price}");
                            break;
                        case 'F':
                            price = 1.5;
                            validSelection = true;
                            Program.Bank.Withdrawal(price);
                            Program.Inventory.Products("Diet-Coke");
                            dietCoke.Quantity = dietCoke.Quantity - 1;
                            Console.WriteLine($"Thank you for purchasing a Diet-Coke, your total is ${price}");
                            break;
                        default:
                            Console.WriteLine("Not a valid selection, please try again");
                            selection = Convert.ToChar(Console.ReadLine().ToUpper());
                            break;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Sorry, you need to deposit some money first");
                }
            }
            
        }
    }
}