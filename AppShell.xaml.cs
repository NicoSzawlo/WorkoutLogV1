using WorkoutLogV1.Views;
namespace WorkoutLogV1;

public partial class AppShell : Shell
{
	public AppShell()
	{
        InitializeComponent();
		Routing.RegisterRoute(nameof(Views.DetailWeightTrainingPage), typeof(Views.DetailWeightTrainingPage));
        Routing.RegisterRoute(nameof(Views.DetailCardioTrainingPage), typeof(Views.DetailCardioTrainingPage));
        Routing.RegisterRoute(nameof(Views.AddEntryPopup), typeof(Views.AddEntryPopup));
	}
}
