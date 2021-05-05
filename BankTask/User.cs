using System;
using CardNamespace;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Card CreditCard { get; set; }
        public User(string name, string surname, Card creditcard)
        {
            Name = name;
            Surname = surname;
            CreditCard = creditcard;
        }
        public override string ToString()
        {
            return $@"
            Name : {Name}
            Surname : {Surname}
";
        }

        public void Show()
        {
            Console.WriteLine($"name : {Name}");
            Console.WriteLine($"surname : {Surname}");
            Console.WriteLine($"credit card : {CreditCard }");
        }

    }
}
