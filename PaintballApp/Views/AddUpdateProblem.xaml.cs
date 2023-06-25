using PaintballApp.ViewModels;

namespace PaintballApp.Views;

public partial class AddUpdateProblem : ContentPage
{
	public AddUpdateProblem(AddUpdateProblemViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}