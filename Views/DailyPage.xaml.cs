using CommunityToolkit.Maui.Views;
using WorkoutLogV1.ViewModels;

namespace WorkoutLogV1.Views;

public partial class DailyPage : ContentPage
{
	DailyViewModel viewmodel = new();
	public DailyPage()
	{
		InitializeComponent();
		BindingContext = viewmodel;
	}
	void onAddEntryClicked(object sender, EventArgs e)
	{
        var popup = new Views.AddEntryPopup();
        this.ShowPopup(popup);
    }
}