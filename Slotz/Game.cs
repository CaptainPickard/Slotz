using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotz
{
    class Game
    {
        public void playGame()
        {
            Wallet wallet = new Wallet();

            int money;
            int cash;

            money = wallet.fillWallet();
            wallet.setWallet(money);
            cash = wallet.getWallet();

            Spin pullLever = new Spin();
            pullLever.spin(wallet);
            Console.WriteLine();

        }
    }
}