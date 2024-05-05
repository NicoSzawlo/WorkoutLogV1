using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
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
		//UI registration
		builder.Services.AddSingleton<DailyPage>();
        builder.Services.AddTransient<DetailWeightTrainingPage>();
        builder.Services.AddTransient<AddEntryPopup>();

        //Viewmodel Registration
        builder.Services.AddSingleton<DailyViewModel>();
        builder.Services.AddTransient<DetailWeightTrainingViewModel>();
        builder.Services.AddTransient<AddEntryViewModel>();

        return builder.Build();
	}
}
