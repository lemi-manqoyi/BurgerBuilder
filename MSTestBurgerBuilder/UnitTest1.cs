using BurgerBuilder;

namespace MSTestBurgerBuilder
{
    [TestClass]
    public class UnitTest1
    {

        BurgerIngredients bi = new BurgerIngredients("Cheese Burger", "Non-Vegan", "Seedless", "Beef", "Gouda", "Gerkins", "Chilli Mayo", 50.00);

        [TestMethod]
        public void TestBurgerName()
        {
            string tBurgername = "Cheese Burger";
            Assert.AreEqual(bi["burgername"], tBurgername);
        }

        [TestMethod]
        public void TestBurgerType()
        {
            string tBurgerType = "Non-Vegan";
            Assert.AreEqual(bi[1], tBurgerType);
        }

        [TestMethod]
        public void TestBunType()
        {
            string tBunType = "Seedless";
            Assert.AreEqual(bi["buntype"], tBunType);
        }

        [TestMethod]
        public void TestPattyType()
        {
            string tPattyType = "Beef";
            Assert.AreEqual(bi[3], tPattyType);
        }

        [TestMethod]
        public void fTestCheeseType()
        {
            string tCheeseType = "Mozarella";
            Assert.AreNotEqual(bi["cheesetype"], tCheeseType);
        }
    }
}