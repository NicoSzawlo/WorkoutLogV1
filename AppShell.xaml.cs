using WorkoutLogV1.Services;
using WorkoutLogV1.Views;
namespace WorkoutLogV1;

public partial class AppShell : Shell
{
	public AppShell()
	{
        InitializeComponent();
		Routing.RegisterRoute("DetailPage", typeof(DetailPage));
		Routing.RegisterRoute("DailyPage", typeof(DailyPage));
	}
}
