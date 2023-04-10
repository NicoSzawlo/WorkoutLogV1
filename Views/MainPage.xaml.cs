using CommunityToolkit.Maui.Views;
namespace WorkoutLogV1.Views;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	private void OnCalendarViewClicked(object sender, EventArgs e)
	{
		var popup = new Views.AddEntryPopup();
		this.ShowPopup(popup);
	}
}

