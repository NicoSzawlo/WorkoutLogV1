using WorkoutLogV1.ViewModels;

namespace WorkoutLogV1.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}