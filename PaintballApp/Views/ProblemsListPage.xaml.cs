using Microsoft.Toolkit.Mvvm.Input;
using PaintballApp.ViewModels;

namespace PaintballApp.Views;

public partial class ProblemsListPage : ContentPage
{
	private ProblemsListPageViewModel _viewMode;
	public ProblemsListPage(ProblemsListPageViewModel viewModel)
	{
		InitializeComponent();
		_viewMode = viewModel;
		this.BindingContext = viewModel;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
		_viewMode.GetProblemsListCommand.Execute(null);
    }
    
}