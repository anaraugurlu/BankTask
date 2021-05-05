using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCardNamespace
{
    public class BankCard
    {

        public string Bankname { get; set; }
        public string Username { get; set; }
        public string Pan { get; set; }
        public string Pin { get; set; }
        public string Cvc { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int Balance { get; set; }
        public BankCard(int balance, string bankname, string username, string pan, string pin, string cvc, DateTime expireddate)
        {

            Balance = balance;
            Bankname = bankname;
            Username = username;
            Pan = pan;
            Pin = pin;
            Cvc = cvc;
            ExpiredDate = expireddate;
        }

        public BankCard()
        {
        }
        //public bool GetPin(int pin, User[] Users)
        //{
        //    foreach (var item in Users)
        //    {


        //        if (pin.ToString() == item.CreditCard.Pin)
        //        {

        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public  decimal GetDecreaseBalance(int money)
        //{
        //    decimal result = Balance - money;
        //    return result;
        //}
        public void Show()
        {
            Console.WriteLine($"pan : {Pan}");
            Console.WriteLine($"Pin : {Pin }");
            Console.WriteLine($" Cvc : {Cvc } ");
            Console.WriteLine($" Expired date : {ExpiredDate  } ");
            Console.WriteLine($" username : {Username  } ");
            Console.WriteLine($" bank name : {Bankname  } ");
            Console.WriteLine($" balance : {Balance  } ");
        }


        //PAN (kartin uzerindeki 16 reqemli kod) //string
        //PIN( karti bankamata daxil ederken yazdiginiz 4 reqemli kod) string
        //CVC(kartin arxasindaki 3 reqemli kod) / string 100-999(random)
        //ExpireDate (06/2023)
    }

}
