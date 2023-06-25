using PaintballApp.Views;

namespace PaintballApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AddUpdateProblem), typeof(AddUpdateProblem));
        Routing.RegisterRoute(nameof(ProblemDetails), typeof(ProblemDetails));
    }
}
