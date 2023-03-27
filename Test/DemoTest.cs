using NUnit.Framework;
using SS23_SWEN2_TourPlanner.Views;

namespace Test;

[TestFixture]
public class ButtonTest
{
    [Test]
    public void CountIncreasesOnButtonClick()
    {
        var demoPage = new DemoPage();
        demoPage.OnCounterClicked(null, null);
        
        Assert.That(demoPage.Count, Is.EqualTo(1));
    }
    
    [Test]
    public void CountIncreasesFurtherOnButtonClick()
    {
        var demoPage = new DemoPage();
        demoPage.OnCounterClicked(null, null);
        demoPage.OnCounterClicked(null, null);
        
        Assert.That(demoPage.Count, Is.EqualTo(2));
    }
}