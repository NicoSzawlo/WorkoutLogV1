using WorkoutLogV1.Services;
using WorkoutLogV1.Views;
namespace WorkoutLogV1;

public partial class AppShell : Shell
{
	public AppShell()
	{
        InitializeComponent();
		Routing.RegisterRoute(nameof(Views.DetailPage), typeof(Views.DetailPage));
	}
}
