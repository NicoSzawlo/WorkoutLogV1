using WorkoutLogV1.ViewModels;

namespace WorkoutLogV1;

public partial class App : Application
{
	public static DailyViewModel DailyVm = new DailyViewModel();
    public static DetailViewModel DetailVm = new DetailViewModel();
    public App()
	{
		InitializeComponent();

		DailyVm = new DailyViewModel();
		DetailVm = new DetailViewModel();
        MainPage = new AppShell();
	}
}
