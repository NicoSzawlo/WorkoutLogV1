using WorkoutLogV1.ViewModels;

namespace WorkoutLogV1;

public partial class App : Application
{
	public static DailyViewModel DailyViewModel = new DailyViewModel();
	public App()
	{
		InitializeComponent();

		DailyViewModel = new DailyViewModel();
        MainPage = new AppShell();
	}
}
