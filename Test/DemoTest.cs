using NUnit.Framework;
using SS23_SWEN2_TourPlanner;

namespace Test;

[TestFixture]
public class ButtonTest
{
    [Test]
    public void CountIncreasesOnButtonClick()
    {
        var mainPage = new MainPage();
        mainPage.OnCounterClicked(null, null);
        
        Assert.That(mainPage.count, Is.EqualTo(1));
    }
    
    [Test]
    public void CountIncreasesFurtherOnButtonClick()
    {
        var mainPage = new MainPage();
        mainPage.OnCounterClicked(null, null);
        mainPage.OnCounterClicked(null, null);
        
        Assert.That(mainPage.count, Is.EqualTo(2));
    }
}