using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using WorkoutLogV1.Services;
using WorkoutLogV1.ViewModels;
using WorkoutLogV1.Views;

namespace WorkoutLogV1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		
		builder.Services.AddSingleton<INavigationService, NavigationService>();
		//UI registration
		builder.Services.AddSingleton<DailyPage>();
        builder.Services.AddSingleton<DetailPage>();
        builder.Services.AddSingleton<AddEntryPopup>();

        //Viewmodel Registration
        builder.Services.AddSingleton<DailyViewModel>();
        builder.Services.AddSingleton<DetailViewModel>();
        builder.Services.AddSingleton<AddEntryViewModel>();

        return builder.Build();
	}
}
