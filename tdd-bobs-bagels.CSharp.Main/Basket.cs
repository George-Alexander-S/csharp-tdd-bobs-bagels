﻿using System;
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
            "Coke",
            "Grandiosa",
            "Eplejuice"
        };

        List<string> basketContent = new List<string>();

        int cap = 3;

        public bool AddItem (string product)
        {
            if (shopItems.Contains(product))
            {
                if (isRoom())
                {
                    basketContent.Add((product));
                    return true;
                }
                else return false;
                
            } 
            else return false;
            
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

        public bool isRoom()
        {
            if (cap <= basketContent.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int changeCap(int newcap)
        {
            return cap = newcap;
        }

        public string RemoveItemWithAlert(string product)
        {
            return "nope";
        }
    }
}
