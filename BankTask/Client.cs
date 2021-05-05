using System;
using BankCardNamespace;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNamespace
{
   public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public BankCard Bankcard { get; set; }
        public Client(int id, string name, string surname, int age, int salary, BankCard bankcard)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            Bankcard = bankcard;
        }



        public void Show()
        {
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($" Surname : {Surname } ");
            Console.WriteLine($" Age : {Age } ");
            Console.WriteLine($" salary : {Salary } ");
            Console.WriteLine($" bankcard : {Bankcard  } ");
        }

    }

}

