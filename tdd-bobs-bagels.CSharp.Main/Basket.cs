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
        List<string> shopItems = new List<string>
        {
            "Coke"
        };

        List<string> basketContent = new List<string>();

        public bool AddItem (string product)
        {
            if (shopItems.Contains(product))
            {
                basketContent.Add((product));
                return true;
            } 
            else
            {
                return false;
            }
        }

        public bool RemoveItem(string product)
        {
            if (basketContent.Contains(product))
            {
                basketContent.Remove(product);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
