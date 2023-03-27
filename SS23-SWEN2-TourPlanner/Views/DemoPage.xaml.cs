namespace SS23_SWEN2_TourPlanner.Views;

public partial class DemoPage : ContentPage
{
    public int Count = 0;

    public DemoPage()
    {
        InitializeComponent();
    }

    public void OnCounterClicked(object sender, EventArgs e)
    {
        Count++;

        if (Count == 1)
            CounterBtn.Text = $"Clicked {Count} time";
        else
            CounterBtn.Text = $"Clicked {Count} times";
    }
}