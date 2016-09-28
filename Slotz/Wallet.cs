using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotz
{
    class Wallet
    {

        bool isInt = false;
        private int result;
        private int money;

        public int fillWallet()
        {

            Console.WriteLine("Please input a wallet amount in an increment of 5");
            isInt = false;

            while (!isInt)
            {

                try
                {

                    string input = Console.ReadLine();
                    result = Int32.Parse(input);

                    if (result % 5 == 0)
                    {
                        isInt = true;
                        Console.WriteLine(" ");
                        Console.WriteLine("Added $" + result + " to your wallet");
                        money = result;


                    }
                    else
                    {
                        isInt = false;
                        Console.WriteLine(" ");
                        Console.WriteLine("Invalid entry. Please enter an int in an increment of 5");

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Invalid entry. Please enter an int in an increment of 5");

                }

            } return result;
        }

        public int cashOut(int money)
        {
            Console.WriteLine();
            Console.WriteLine("You just cashed out. You have $" + money);
            Console.WriteLine();
            Console.WriteLine("Thank you for playing!");
            //System.Threading.Thread.Sleep(800);
            return money;
        }

        public int getWallet()
        {
            return money;
        }

        public void setWallet(int amount)
        {
            money = amount;
        }


    }
}