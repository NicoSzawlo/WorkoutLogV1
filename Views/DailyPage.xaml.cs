using CommunityToolkit.Maui.Views;
using WorkoutLogV1.ViewModels;

namespace WorkoutLogV1.Views;

public partial class DailyPage : ContentPage
{
	public DailyPage()
	{
		InitializeComponent(); 
	}
	void onAddEntryClicked(object sender, EventArgs e)
	{
        var popup = new Views.AddEntryPopup();
        this.ShowPopup(popup);
    }
}