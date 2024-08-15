namespace csharp_tdd_bobs_bagels.tests;

using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using tdd_bobs_bagels.CSharp.Main;

public class BasketTest
{
    [TestCase("Coke")]
    [TestCase("Grandiosa")]
    [TestCase("Eplejuice")]
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
    [TestCase("Grandiosa")]
    [TestCase("Eplejuice")]
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

    [Test]
    public void fullBasketTest()
    {
        //arrange
        Basket basket = new Basket();
        bool expected = false;
        basket.AddItem("Coke");
        basket.AddItem("Coke");
        basket.AddItem("Coke");

        //act
        bool result = basket.AddItem("Coke");

        //assert
        Assert.IsTrue(result == expected);
    }

    [Test]
    public void roomBasketTest()
    {
        //arrange
        Basket basket = new Basket();
        bool expected = true;
        basket.AddItem("Coke");
        basket.AddItem("Coke");

        //act
        bool result = basket.AddItem("Coke");

        //assert
        Assert.IsTrue(result == expected);
    }

    [Test]
    public void changeCapTest()
    {
        //arrange
        Basket basket = new Basket();
        int expected = 4;

        //act
        int change = basket.changeCap(4);

        //assert
        Assert.IsTrue(expected == change);
        
    }
}