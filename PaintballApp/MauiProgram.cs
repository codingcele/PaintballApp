using PaintballApp.Services;
using PaintballApp.ViewModels;
using PaintballApp.Views;

namespace PaintballApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        //Services
        builder.Services.AddSingleton<IProblemService, ProblemService>();

        //Views registration
        builder.Services.AddSingleton<ProblemsListPage>();
        builder.Services.AddTransient<AddUpdateProblem>();

        builder.Services.AddSingleton<ProblemDetails>();

        //View Models
        builder.Services.AddSingleton<ProblemsListPageViewModel>();
        builder.Services.AddTransient<AddUpdateProblemViewModel>();

        builder.Services.AddSingleton<ProblemDetailsViewModel>();

        return builder.Build();
	}
}
