using System;
using UserNamespace;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperNamespace
{
   public  class Helper
    {
        public static void ShowFirstChoice()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("please choose one of the following");
            Console.WriteLine("1-Balanse");
            Console.WriteLine("2-neğd pul");
            Console.WriteLine("3-kartdan karta kochurme");
        }
        public static void ShowSecondChoice()
        {
            Console.WriteLine("1-10 azn");
            Console.WriteLine("2-20 azn");
            Console.WriteLine("3-50 azn");
            Console.WriteLine("4-100 azn");
            Console.WriteLine("5-Enter the amount you want");
        }

        public static decimal Getbalance(int pin, User[] Users)
        {

            foreach (var item in Users)
            {
                if (pin.ToString() == item.CreditCard.Pin)
                {
                    return item.CreditCard.Balance;
                }
            }
            return 0;
        }
        public static decimal ReduceBalanceByUser(int pin, int money, User[] Users)
        {
            foreach (var item in Users)
            {
                if (pin.ToString() == item.CreditCard.Pin)
                {
                    decimal result = item.CreditCard.Balance - money;
                    return result;
                }
            }
            return 0;
        }
        public static string CheckPin(int pin, User[] Users)
        {
            foreach (var item in Users)
            {
                if (pin.ToString() == item.CreditCard.Pin)
                {

                    return item.ToString();
                }
            }
            return "there is no such user ";
        }
        public static decimal IncreaseBalance(int pin, int money, User[] Users)
        {
            foreach (var item in Users)
            {
                if (pin.ToString() == item.CreditCard.Pin)
                {
                    decimal result = item.CreditCard.Balance + money;
                    return result;
                }
            }
            return 0;
        }
        public static bool Control(string pin)
        {
            if (pin.Length == 4)
            {
                return true;
            }
            return false;
        }
    }
}
