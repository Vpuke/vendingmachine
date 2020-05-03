using System; 
using System.Collections.Generic;


namespace VendingMachineAssignment
{
    public class Bank
    {
        public double Amount { get; set; }

        List<double> DepositList = new List<double>();

        public double Balance()
        {
            Amount = Amount;
            Console.WriteLine($"Your current Balance is ${Amount}");
            return Amount;

        }
        
        public double Deposit()
        {   
            
            Console.WriteLine("Available Balance: {0}", Amount);
            Console.WriteLine("How much would you like to deposit? ");
            double DepositAmt = Convert.ToDouble(Console.ReadLine());
            
            DepositList.Add(DepositAmt);

            Amount = Amount + DepositAmt;
            Console.WriteLine($"Your Balance is: ${Amount}");

            return DepositAmt;

        }

        public double Withdrawal(double value)
        {
            if (value > Amount)
                throw new Exception("lol not enough cash");
            Amount = Amount - value;
            return value;
        }
    }
}