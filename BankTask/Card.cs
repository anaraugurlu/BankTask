 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardNamespace
{
   public  class Card
    {
        public string Pan { get; set; }
        public string Pin { get; set; }
        public string Cvc { get; set; }
        public DateTime ExpiredDate { get; set; }
        public decimal Balance { get; set; }
        public Card(decimal balance, string pan, string pin, string cvc, DateTime expireddate)
        {

            Balance = balance;
            Pan = pan;
            Pin = pin;
            Cvc = cvc;
            ExpiredDate = expireddate;
        }

        public Card()
        {
        }
        //public decimal GetDecreaseBalance(int money)
        //{

        //    decimal result = Balance - money;
        //    return result;
        //}
        public void Show()
        {
            Console.WriteLine($"Pan : {Pan}");
            Console.WriteLine($"pin : {Pin}");
            Console.WriteLine($"balance : {Balance }");
            Console.WriteLine($" cvc : {Cvc } ");
            Console.WriteLine($" date : {ExpiredDate } ");
        }
    }
}

