using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSystem
{
    public class Coffeeshop
    {
        private double coffeeprice;
        private double sandwitchprice;

        public string Setcoffeeprice(double coffeeprice)
        {
            if (sandwitchprice > 0)
            {
                this.coffeeprice = coffeeprice;
                return "Price Set Successfully";

            }
            else
            {
                return "Price Cannot be negative";
            }
        }
        public double Getcoffeeprice()
        {
            return this.coffeeprice;
        }

        public string Setsandwitchprice(double sandwitchprice)
        {
            if (sandwitchprice > 0)
            {
                this.sandwitchprice = sandwitchprice;
                return "Price Set Successfully";

            }
            else
            {
                return "Price Cannot be negative";
            }
        }
        public double Getsandwitchprice()
        {
            return this.sandwitchprice;
        }

        public string order(string name, bool coffee, bool sandwitch)
        {
            double price = 0;
            if (name == "")
            {
                return " name is required";
            }
            if (!coffee && !sandwitch)
            {
                return "you have to place order of atleat one thing";
            }
            
            return "Customer Name : " + name + "\nTotal amount : " + AmountCalculation(coffee,sandwitch);
        }
        public double AmountCalculation(bool coffee, bool sandwitch)
        {
            double price = 0;
            if (coffee)
            {
                price += Getcoffeeprice();
            }
            if (sandwitch)
            {
                price += Getsandwitchprice();
            }
            return price;
        }
       
        
    }
}
