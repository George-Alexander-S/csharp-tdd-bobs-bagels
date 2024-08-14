using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        Dictionary<string, int> shopItems = new Dictionary<string, int>
        {
            {"Coke", 10 }
        };

        List<(string, int)> basketContent = new List<(string, int)>();

        public bool AddItem (string product, int price)
        {
            if (shopItems.ContainsKey(product))
            {
                price = shopItems[product];
                basketContent.Add((product, price));
                return true;
            } else
            {
                return false;
            }
        }
    }
}
