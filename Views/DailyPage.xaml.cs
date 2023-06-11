using CommunityToolkit.Maui.Views;
using WorkoutLogV1.ViewModels;

namespace WorkoutLogV1.Views;

public partial class DailyPage : ContentPage
{
	public DailyPage(DailyViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}