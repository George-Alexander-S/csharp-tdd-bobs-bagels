namespace csharp_tdd_bobs_bagels.tests;
using tdd_bobs_bagels.CSharp.Main;

public class BasketTest
{
    [TestCase("Coke", 10)]
    public void addItemTest(string product, int price)
    {
        //arrange
        Basket basket = new Basket();

        ////tuple lists are cool
        //List<(string, int)> basketContent = new List<(string, int)>();

        bool expected = true;

        //act

        bool result = basket.AddItem(product, price);

        //assert

        Assert.IsTrue(result == expected);
    }

    [TestCase("Coke")]
    public void removeItemTest(string product)
    {
        //arrange
        Basket basket = new Basket();
        bool expected = true;

        //act
        bool result = basket.RemoveItem(product);

        //assert
        Assert.IsTrue(result == expected);
    } 

}