namespace BurgerBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BurgerIngredients bi = new BurgerIngredients("Mish Burger", "Veggie Burger", "Seeded Bun", "Mish Burger", "Veggie", "Plantbased cheese", "Barbeque sauce", 52.99);

            string dispInt = ("--------------accessing using int");
            Console.WriteLine(dispInt + "\nBurger Name: " + bi[0] + "\nBurger Type: " + bi[1] + "\nBun Type: " + bi[2] + "\nPatty Type: " + bi[3] +
                "\nCheese Type: " + bi[4] + "\nExtra Ingredients: " + bi[5] + "\nSauce Type: " + bi[6] + "\nPrice: " + bi[7]);

            BurgerIngredients bi2 = new BurgerIngredients("Mish Burger", "Veggie Burger", "Seeded Bun", "Mish Burger", "Veggie", "Plantbased cheese", "Barbeque sauce", 52.99);
            string dispInt2 = ("--------------accessing using int");
            Console.WriteLine(dispInt2 + "\nBurger Name: " + bi2["burgerName"] + "\nBurger Type: " + bi2["burgerType"] + "\nBun Type: " + bi2["bunType"]
                + "\nPatty Type: " + bi2["pattyType"] + "\nCheese Type: " + bi2["cheeseType"] + "\nExtra Ingredients: " + bi2["extraIngr"] + "\nSauce Type: "
                + bi2["sauceType"] + "\nPrice: " + bi2["price"]);
        }
    }
}
