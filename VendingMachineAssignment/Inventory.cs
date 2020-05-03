using System;
using System.Collections.Generic;


namespace VendingMachineAssignment
{
    public class Inventory
    {
        private List<string> _inventoryList = new List<string>();

        public string Products(string value)
        {
            
            _inventoryList.Add(value);
            return value;
        }

        public void Display()
        {
           
            foreach (var value in _inventoryList)
            {
                Console.WriteLine(value);
            }
        }
    }
}