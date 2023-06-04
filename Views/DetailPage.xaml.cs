using WorkoutLogV1.ViewModels;

namespace WorkoutLogV1.Views;

public partial class DetailPage : ContentView
{
	public DetailPage(DetailViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}