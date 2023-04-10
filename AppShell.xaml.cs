using WorkoutLogV1.Views;
namespace WorkoutLogV1;

public partial class AppShell : Shell
{
	public AppShell()
	{
        Routing.RegisterRoute("DailyPage", typeof(DailyPage));
        Routing.RegisterRoute("CalendarPage", typeof(CalendarPage));
        Routing.RegisterRoute("PrPage", typeof(PrPage));
        InitializeComponent();
	}
}
