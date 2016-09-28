using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotz
{
    class Spin
    {

        private bool go;
        private int money;
        public void spin(Wallet wallet)
        {

            Random randNum = new Random();
            money = wallet.getWallet();

            Console.WriteLine();
            Console.WriteLine("Press Enter to roll or Q to cash out and quit");

            go = false;


            while (money >= 5 && go == false)
            {
                string response = Console.ReadLine().ToLower();

                if (response.Equals(""))
                {

                    int rand1 = randNum.Next(0, 9);
                    int rand2 = randNum.Next(0, 9);
                    int rand3 = randNum.Next(0, 9);
                    int Value = Convert.ToInt32("" + rand1 + rand2 + rand3);
                    String Value2 = Value.ToString("D3");
                    Console.WriteLine("You rolled a " + Value2);
                    Console.WriteLine();

                    if (Value == 111)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You win a free spin!");
                        money = money + 0;
                    }
                    else if (Value == 222)
                    {
                        money = money * 2;
                    }
                    else if (Value == 333)
                    {
                        money = money * 3;
                    }
                    else if (Value == 444)
                    {
                        money = money * 4;
                    }
                    else if (Value == 555)
                    {
                        money = money * 5;
                    }
                    else if (Value == 666)
                    {
                        money = money * 6;
                    }
                    else if (Value == 777)
                    {
                        money = money * 7;
                    }
                    else if (Value == 888)
                    {
                        money = money * 8;
                    }
                    else if (Value == 999)
                    {
                        money = money * 9;
                    }
                    else if (Value == 000)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You rolled all $$$!");
                        System.Threading.Thread.Sleep(500);
                        money = money * 10;
                    }
                    else if (rand1 == rand2 || rand2 == rand3 || rand3 == rand1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You matched two numbers!");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(500);
                        money = money + 2;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("You didn't get a match. You lose your bet.");
                        Console.WriteLine();
                        money = money - 5;

                    }

                    Console.WriteLine("Wallet: " + money);
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Would you like to roll again? enter for yes q for no.");

                }

                else if (response.Equals("q"))
                {
                    wallet.cashOut(money);
                    go = true;
                }
                else if (!response.Equals("") || !response.Equals("q"))
                {
                    Console.WriteLine("Press Enter to roll or Esc to cash out and quit");
                    System.Threading.Thread.Sleep(500);
                }

            }
            if (money <= 0)
            {
                reSpin(wallet);
            }

            if (money < 5)
            {
                reSpin(wallet);
            }

        }

        public void reSpin(Wallet wallet)
        {


            string response2 = Console.ReadLine().ToLower();
            if (response2.Equals(""))
            {
                Console.WriteLine("Sorry you don't have enough money to bet.");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("Would you like to add money to your wallet? Enter for yes q for no.");
                string response3 = Console.ReadLine().ToLower();


                if (response3.Equals(""))
                {
                    wallet.fillWallet();

                    money = money + wallet.getWallet();

                    Console.WriteLine();
                    wallet.setWallet(money);
                    Console.WriteLine("Wallet: " + money);
                    spin(wallet);

                }
                else if (response3.Equals("q"))
                {
                    Console.WriteLine("You have $" + money);
                    Console.WriteLine();
                    Console.WriteLine("Thank you for Playing!");
                    System.Threading.Thread.Sleep(500);
                    go = true;
                }
                else if (!response3.Equals("") || !response3.Equals("q"))
                {
                    Console.WriteLine("Would you like to add money to your wallet? Enter for yes q for no.");
                    go = false;
                }

            }
            else if (response2.Equals("q"))
            {
                Console.WriteLine("You have $" + money);
                Console.WriteLine();
                Console.WriteLine("Thank you for Playing!");
                System.Threading.Thread.Sleep(500);
                go = true;

            }


        }
    }

}