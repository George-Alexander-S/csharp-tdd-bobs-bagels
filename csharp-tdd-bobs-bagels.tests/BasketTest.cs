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

        //tuple lists are cool
        var basketContent = new List<(string product, int amount)> { };
        bool expected = true;

        //act

        bool result = basket.Add(product, price);

        //assert

        Assert.IsTrue(result);
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}