namespace csharp_tdd_bobs_bagels.tests;
using tdd_bobs_bagels.CSharp.Main;

public class BasketTest
{
    [TestCase("Coke")]
    public void addItemTest(string product)
    {
        //arrange
        Basket basket = new Basket();

        ////tuple lists are cool
        //List<(string, int)> basketContent = new List<(string, int)>();

        bool expected = true;

        //act

        bool result = basket.AddItem(product);

        //assert

        Assert.IsTrue(result == expected);
    }

    [TestCase("Coke")]
    public void removeItemTest(string product)
    {
        //arrange
        Basket basket = new Basket();
        bool expected = true;
        basket.AddItem(product);

        //act
        bool result = basket.RemoveItem(product);

        //assert
        Assert.IsTrue(result == expected);
    } 

}