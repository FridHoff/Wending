using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending
{
    internal class WendingMachine
    {
        int[] balance = { 100, 50, 25, 10 };
        int[] money = { 1, 2, 5, 10 };
        string[] goods = { "fanta", "sprite", "cola", "pepsy" };
        int[] goodsAmount = new int[3];
        void AddMoney(int amount, int id)
        {
            balance[id] += amount;
        }
        void BuyGood(int id, int amount)
        {
            goodsAmount[id] -= amount;           
        }

    }
}
