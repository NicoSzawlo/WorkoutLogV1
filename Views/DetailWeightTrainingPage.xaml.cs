using WorkoutLogV1.ViewModels;

namespace WorkoutLogV1.Views;

public partial class DetailWeightTrainingPage : ContentPage
{
	public DetailWeightTrainingPage(DetailWeightTrainingViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}