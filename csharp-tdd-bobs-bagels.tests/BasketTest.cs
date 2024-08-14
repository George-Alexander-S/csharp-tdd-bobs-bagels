namespace csharp_tdd_bobs_bagels.tests;
using tdd_bobs_bagels.CSharp.Main;

public class BasketTest
{
    [TestCase("Coke", 10)]
    public void addItemTest(string product, int price)
    {
        //arrange
        Basket basket = new Basket();

        Dictionary<string, int> shopItems = new Dictionary<string, int>();

        ////tuple lists are cool
        //List<(string, int)> basketContent = new List<(string, int)>();

        bool expected = true;

        //act

        bool result = basket.AddItem(product, price);

        //assert

        Assert.IsTrue(result);
    }

}