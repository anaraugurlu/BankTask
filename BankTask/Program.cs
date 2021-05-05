using System;
using ClientNamespace;
using UserNamespace;
using HelperNamespace;
using CardNamespace;
using BankCardNamespace;
using BankNamespace;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ////task1
            //DateTime d = new DateTime(2021, 3, 1);
            //Random randomcvc = new Random();
            //var datacvc = randomcvc.Next(100, 999);
            //Random randombalance = new Random();
            //int date = d.Year;
            //var databalance = randombalance.Next(100, 900);
            //Console.WriteLine("include pin");
            //bool isIntPin = int.TryParse(Console.ReadLine(), out int pin);
            //Console.WriteLine("include pan");
            //bool isIntPan = int.TryParse(Console.ReadLine(), out int pan);
            //Console.WriteLine("include cvc");
            //bool isIntCvc = int.TryParse(Console.ReadLine(), out int cvc);
            //if (isIntPin && isIntPan && isIntCvc)
            //{
            //    if (!Helper.Control(pin.ToString(), pan.ToString(), cvc.ToString(), d.Year))
            //    {
            //        Console.WriteLine("please try again");
            //        throw new Exception();
            //    }
            //    else
            //    {
            //        BankCard b1 = new BankCard(databalance, "bank", "anaraugurlu", pan.ToString(), pin.ToString(), datacvc.ToString(), d);
            //        Client c1 = new Client(2, "anara", "ugurlu", 18, 2000, b1);
            //        Bank bank = new Bank();
            //        b1.Show();
            //        c1.Show();
            //        bank.AddClient(ref c1);
            //        bank.Show();
            //    }
            //}
            //Task2
            DateTime d1 = new DateTime(2021, 2, 3);
            int date1 = d1.Year;
            DateTime d2 = new DateTime(2022, 3, 4);
            int date2 = d2.Year;
            DateTime d3 = new DateTime(2024, 4, 5);
            int date3 = d3.Year;
            DateTime d4 = new DateTime(2025, 5, 6);
            int date4 = d4.Year;
            DateTime d5 = new DateTime(2023, 3, 3);
            int date5 = d5.Year;
            string[] pans = { "1234567890", "2345167891", "3567898765", "3214326547", "3213213212" };
            string[] pins = { "1234", "4321", "2222", "1111", "1212" };
            string[] cvcs = { "123", "321", "222", "111", "333" };
            Console.WriteLine("include pin");
            bool isIntPin = int.TryParse(Console.ReadLine(), out int pin);
            Card c1 = new Card(3000, pans[0], pins[0], cvcs[0], d1);
            User u1 = new User("Nezrin", "rehimli", c1);
            Card c2 = new Card(2000, pans[1], pins[1], cvcs[1], d2);
            User u2 = new User("zeyneb", "esgerova", c2);
            Card c3 = new Card(3000, pans[2], pins[2], cvcs[2], d3);
            User u3 = new User("rena", "eliyeva", c3);
            Card c4 = new Card(2000, pans[3], pins[3], cvcs[3], d4);
            User u4 = new User("zeyneb", "rehmanova", c4);
            Card c5 = new Card(2000, pans[4], pins[4], cvcs[4], d5);
            User u5 = new User("fidan", "rehmanova", c5);
            User[] Users = { u1, u2, u3, u4, u5 };
            if (!Helper.Control(pin.ToString()/*, pan.ToString(), cvc.ToString(), d.Year*/))
            {
                Console.WriteLine("please try again");
                throw new Exception();
            }
            else
            {
                Helper.CheckPin(pin, Users);
                Helper.ShowFirstChoice();
                bool isInt = int.TryParse(Console.ReadLine(), out int result);
                if (result == 1)
                {
                    Console.WriteLine(Helper.Getbalance(pin, Users));
                    Console.WriteLine("exit");
                    if (Console.ReadLine() == "exit")
                    {
                        Console.WriteLine("2-negd pul");
                        bool isInt5 = int.TryParse(Console.ReadLine(), out int result5);
                        if (result5 == 2)
                        {
                            Helper.ShowSecondChoice();
                            bool isInt2 = int.TryParse(Console.ReadLine(), out int result2);
                            if (Helper.Getbalance(pin, Users) < result)
                            {
                                throw new Exception("no balance please try again");
                            }
                            else
                            {
                                if (result2 == 1)
                                {
                                    Console.WriteLine("the operation ended successfully");
                                    Console.WriteLine("current balance");
                                    Console.WriteLine(Helper.ReduceBalanceByUser(pin, 10, Users));
                                    Helper.ShowFirstChoice();
                                    bool isInt4 = int.TryParse(Console.ReadLine(), out int result4);
                                    if (result4 == 1)
                                    {
                                        Console.WriteLine(Helper.ReduceBalanceByUser(pin, 10, Users));
                                    }
                                }
                                else if (result2 == 2)
                                {
                                    Console.WriteLine("the operation ended successfully");
                                    Console.WriteLine("current balance");
                                    Console.WriteLine(Helper.ReduceBalanceByUser(pin, 20, Users));
                                    Helper.ShowFirstChoice();
                                    bool isInt4 = int.TryParse(Console.ReadLine(), out int result4);
                                    if (result4 == 1)
                                    {
                                        Console.WriteLine(Helper.ReduceBalanceByUser(pin, 20, Users));
                                    }
                                }
                                else if (result2 == 3)
                                {
                                    Console.WriteLine("the operation ended successfully");
                                    Console.WriteLine("current balance");
                                    Console.WriteLine(Helper.ReduceBalanceByUser(pin, 50, Users));
                                    Helper.ShowFirstChoice();
                                    bool isInt4 = int.TryParse(Console.ReadLine(), out int result4);
                                    if (result4 == 1)
                                    {
                                        Console.WriteLine(Helper.ReduceBalanceByUser(pin, 50, Users));
                                    }
                                }
                                else if (result2 == 4)
                                {
                                    Console.WriteLine("the operation ended successfully");
                                    Console.WriteLine("current balance");
                                    Console.WriteLine(Helper.ReduceBalanceByUser(pin, 100, Users));
                                    Helper.ShowFirstChoice();
                                    bool isInt4 = int.TryParse(Console.ReadLine(), out int result4);
                                    if (result4 == 1)
                                    {
                                        Console.WriteLine(Helper.ReduceBalanceByUser(pin, 100, Users));
                                    }
                                }
                                else if (result2 == 5)
                                {
                                    Console.WriteLine("record the amount you want");
                                    bool isInt3 = int.TryParse(Console.ReadLine(), out int result3);
                                    if (Helper.Getbalance(pin, Users) < result3)
                                    {
                                        throw new Exception("no balance please try again");
                                    }
                                    else
                                    {
                                        Console.WriteLine("the operation ended successfully");
                                        Console.WriteLine("current balance");
                                        Console.WriteLine(Helper.ReduceBalanceByUser(pin, result3, Users));
                                        Helper.ShowFirstChoice();
                                        bool isInt4 = int.TryParse(Console.ReadLine(), out int result4);
                                        if (result4 == 1)
                                        {
                                            Console.WriteLine(Helper.ReduceBalanceByUser(pin, result3, Users));
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("invalid argument");
                        }
                    }
                }
                else if (result == 2)
                {
                    Helper.ShowSecondChoice();
                    bool isInt2 = int.TryParse(Console.ReadLine(), out int result2);
                    if (Helper.Getbalance(pin, Users) < result)
                    {
                        throw new Exception("no balance please try again");
                    }
                    else
                    {
                        if (result2 == 1)
                        {
                            Console.WriteLine("the operation ended successfully");
                            Console.WriteLine("current balance");
                            Console.WriteLine(Helper.ReduceBalanceByUser(pin, 10, Users));
                            Helper.ShowFirstChoice();
                            bool isInt4 = int.TryParse(Console.ReadLine(), out int result4);
                            if (result4 == 1)
                            {
                                Console.WriteLine(Helper.ReduceBalanceByUser(pin, 10, Users));
                            }
                        }
                        else if (result2 == 2)
                        {
                            Console.WriteLine("the operation ended successfully");
                            Console.WriteLine("current balance");
                            Console.WriteLine(Helper.ReduceBalanceByUser(pin, 20, Users));
                            Helper.ShowFirstChoice();
                            bool isInt4 = int.TryParse(Console.ReadLine(), out int result4);
                            if (result4 == 1)
                            {
                                Console.WriteLine(Helper.ReduceBalanceByUser(pin, 20, Users));
                            }
                        }
                        else if (result2 == 3)
                        {
                            Console.WriteLine("the operation ended successfully");
                            Console.WriteLine("current balance");
                            Console.WriteLine(Helper.ReduceBalanceByUser(pin, 50, Users));
                            Helper.ShowFirstChoice();
                            bool isInt4 = int.TryParse(Console.ReadLine(), out int result4);
                            if (result4 == 1)
                            {
                                Console.WriteLine(Helper.ReduceBalanceByUser(pin, 50, Users));
                            }
                        }
                        else if (result2 == 4)
                        {
                            Console.WriteLine("the operation ended successfully");
                            Console.WriteLine("current balance");
                            Console.WriteLine(Helper.ReduceBalanceByUser(pin, 100, Users));
                            Helper.ShowFirstChoice();
                            bool isInt4 = int.TryParse(Console.ReadLine(), out int result4);
                            if (result4 == 1)
                            {
                                Console.WriteLine(Helper.ReduceBalanceByUser(pin, 100, Users));
                            }
                        }
                        else if (result2 == 5)
                        {
                            Console.WriteLine("record the amount you want");
                            bool isInt3 = int.TryParse(Console.ReadLine(), out int result3);
                            if (Helper.Getbalance(pin, Users) < result3)
                            {
                                throw new Exception("no balance please try again");
                            }
                            else
                            {
                                Console.WriteLine("the operation ended successfully");
                                Console.WriteLine("current balance");
                                Console.WriteLine(Helper.ReduceBalanceByUser(pin, result3, Users));
                                Helper.ShowFirstChoice();
                                bool isInt4 = int.TryParse(Console.ReadLine(), out int result4);
                                if (result4 == 1)
                                {
                                    Console.WriteLine(Helper.ReduceBalanceByUser(pin, result3, Users));
                                }
                            }
                        }
                    }
                }
                else if (result == 4)
                {

                    Console.WriteLine("which card do you want to transfer");
                    bool isInt6 = int.TryParse(Console.ReadLine(), out int pin2);
                    if (!Helper.Control(pin2.ToString()/*, pan.ToString(), cvc.ToString(), d.Year*/))
                    {
                        Console.WriteLine("please try again");
                        throw new Exception();
                        Console.WriteLine("which card do you want to transfer");
                        bool isInt7 = int.TryParse(Console.ReadLine(), out int pin3);
                        Console.WriteLine("record the amount you want transfer");
                        bool isInt8 = int.TryParse(Console.ReadLine(), out int money);

                        Helper.CheckPin(pin3, Users);
                        Console.WriteLine(Helper.IncreaseBalance(pin3, money, Users));
                        Console.WriteLine("the operation ended successfully");

                    }
                    else
                    {
                        Console.WriteLine("which card do you want to transfer");
                        bool isInt7 = int.TryParse(Console.ReadLine(), out int pin3);
                        Console.WriteLine("record the amount you want transfer");
                        bool isInt8 = int.TryParse(Console.ReadLine(), out int money);

                        Helper.CheckPin(pin3, Users);
                        Console.WriteLine(Helper.IncreaseBalance(pin3, money, Users));
                        Console.WriteLine("the operation ended successfully");

                    }

                }
                else
                {
                    throw new Exception("invalid argument ");
                }
            }
        }
    }
}