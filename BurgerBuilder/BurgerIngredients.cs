using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilder
{
    public  class BurgerIngredients
    {
            //intiating global variables
            private double price;
            private string burgerName, burgerType, bunType, pattyType, cheeseType, extraIngr, sauceType;

            public BurgerIngredients(string burgerName, string burgerType, string bunType, string pattyType, string cheeseType, string extraIngr, string sauceType, double price)
            {
                this.burgerName = burgerName;
                this.burgerType = burgerType;
                this.bunType = bunType;
                this.pattyType = pattyType;
                this.cheeseType = cheeseType;
                this.extraIngr = extraIngr;
                this.sauceType = sauceType;
                this.price = price;
            }

            public object this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0: return this.burgerName;
                        case 1: return this.burgerType;
                        case 2: return this.bunType;
                        case 3: return this.pattyType;
                        case 4: return this.cheeseType;
                        case 5: return this.extraIngr;
                        case 6: return this.sauceType;
                        case 7: return this.price;
                        default: return null;
                    }
                }
                set
                {
                    switch (index)
                    {
                        case 0: this.burgerName = (string)(value); break;
                        case 1: this.burgerType = (string)(value); break;
                        case 2: this.bunType = (string)(value); break;
                        case 3: this.pattyType = (string)(value); break;
                        case 4: this.cheeseType = (string)(value); break;
                        case 5: this.extraIngr = (string)(value); break;
                        case 6: this.sauceType = (string)(value); break;
                        case 7: this.price = (double)(value); break;

                    }
                }
            }

            public object this[string attrName]
            {
                get
                {
                    switch (attrName.ToLower())
                    {
                        case "burgername": return this.burgerName;
                        case "burgertype": return this.burgerType;
                        case "buntype": return this.bunType;
                        case "pattytype": return this.pattyType;
                        case "cheesetype": return this.cheeseType;
                        case "extraingr": return this.extraIngr;
                        case "saucetype": return this.sauceType;
                        case "price": return this.price;
                        default: return null;
                    }
                }
                set
                {
                    switch (attrName.ToLower())
                    {
                        case "burgername": this.burgerName = (string)(value); break;
                        case "burgertype": this.burgerType = (string)(value); break;
                        case "buntype": this.bunType = (string)(value); break;
                        case "pattytype": this.pattyType = (string)(value); break;
                        case "cheesetype": this.cheeseType = (string)(value); break;
                        case "extraingr": this.extraIngr = (string)(value); break;
                        case "saucetype": this.sauceType = (string)(value); break;
                        case "price": this.price = (double)(value); break;

                    }
                }
            }

        }
    
}
